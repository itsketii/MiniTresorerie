using System.Drawing.Drawing2D;
using MiniTresorerie.Models;

namespace MiniTresorerie.UInterface.Composants;

public abstract class ControleGraphique : Control
{
    protected ControleGraphique()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
        BackColor = Color.Transparent;
    }

    /// <summary>Convertit une taille en pixels « 100 % » vers la mise à l'échelle réelle de l'écran.</summary>
    protected int S(int v) => (int)Math.Round(v * DeviceDpi / 96f);
    protected float S(float v) => v * DeviceDpi / 96f;

    protected static decimal NiceMax(decimal v)
    {
        if (v <= 0) return 1000;
        double e = Math.Pow(10, Math.Floor(Math.Log10((double)v)));
        double f = (double)v / e;
        double n = f <= 1 ? 1 : f <= 2 ? 2 : f <= 2.5 ? 2.5 : f <= 5 ? 5 : 10;
        return (decimal)(n * e);
    }

    protected void Vide(Graphics g, string message = "Aucune donnée sur la période")
    {
        TextRenderer.DrawText(g, message, Theme.Police(10f), ClientRectangle, Theme.TexteDoux,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }
}

/// <summary>Histogramme groupé recettes / dépenses par mois.</summary>
public class GraphiqueBarres : ControleGraphique
{
    List<PointMensuel> _d = new();
    readonly string[] _mois = { "Jan", "Fév", "Mar", "Avr", "Mai", "Juin", "Juil", "Août", "Sep", "Oct", "Nov", "Déc" };
    readonly ToolTip _tip = new ToolTip();
    int _idx = -1;
    Rectangle _area;

    public List<PointMensuel> Donnees { get => _d; set { _d = value ?? new(); Invalidate(); } }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        Theme.Lisser(g);
        _area = new Rectangle(S(58), S(38), Math.Max(10, Width - S(74)), Math.Max(10, Height - S(38) - S(30)));
        var f = Theme.Police(8.5f);
        var flags = TextFormatFlags.NoPadding | TextFormatFlags.VerticalCenter;

        Legende(g, S(58), S(8), Theme.Emeraude600, "Recettes");
        Legende(g, S(150), S(8), Theme.Or, "Dépenses");

        decimal max = _d.Count == 0 ? 0 : _d.Max(p => Math.Max(p.Recettes, p.Depenses));
        decimal nice = NiceMax(max);
        using var pg = new Pen(Theme.Bordure) { DashStyle = DashStyle.Dash };
        for (int i = 0; i <= 4; i++)
        {
            float y = _area.Bottom - i * _area.Height / 4f;
            g.DrawLine(pg, _area.Left, y, _area.Right, y);
            TextRenderer.DrawText(g, Fmt.Court(nice * i / 4), f, new Rectangle(0, (int)y - S(9), _area.Left - S(6), S(18)),
                Theme.TexteDoux, flags | TextFormatFlags.Right);
        }
        if (_d.Count == 0) return;

        float gw = _area.Width / 12f;
        float bw = Math.Min(S(22f), gw * 0.3f);
        for (int m = 0; m < 12; m++)
        {
            float cx = _area.Left + gw * m + gw / 2f;
            var p = _d.FirstOrDefault(x => x.Mois == m + 1);
            if (p != null)
            {
                Barre(g, cx - bw - 1, p.Recettes, nice, bw, Theme.Emeraude500, Theme.Emeraude700);
                Barre(g, cx + 1, p.Depenses, nice, bw, Color.FromArgb(232, 200, 90), Theme.OrFonce);
            }
            TextRenderer.DrawText(g, _mois[m], f, new Rectangle((int)(cx - gw / 2), _area.Bottom + S(4), (int)gw, S(20)),
                Theme.TexteDoux, flags | TextFormatFlags.HorizontalCenter);
        }
    }

    void Legende(Graphics g, int x, int y, Color c, string texte)
    {
        using var b = new SolidBrush(c);
        using var p = Theme.Arrondi(new RectangleF(x, y + S(4), S(12), S(12)), S(3f));
        g.FillPath(b, p);
        TextRenderer.DrawText(g, texte, Theme.Police(9f), new Rectangle(x + S(18), y, S(90), S(20)), Theme.TexteDoux,
            TextFormatFlags.NoPadding | TextFormatFlags.VerticalCenter);
    }

    void Barre(Graphics g, float x, decimal v, decimal nice, float bw, Color c1, Color c2)
    {
        float h = (float)(v / nice) * _area.Height;
        if (h < 1.5f) return;
        var rect = new RectangleF(x, _area.Bottom - h, bw, h);
        using var path = Theme.ArrondiHaut(rect, S(4f));
        using var lb = new LinearGradientBrush(rect, c1, c2, LinearGradientMode.Vertical);
        g.FillPath(lb, path);
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        if (_d.Count == 0 || _area.Width <= 0) return;
        int idx = (int)((e.X - _area.Left) / (_area.Width / 12f));
        if (idx < 0 || idx > 11) { _tip.SetToolTip(this, ""); _idx = -1; return; }
        if (idx == _idx) return;
        _idx = idx;
        var p = _d.FirstOrDefault(x => x.Mois == idx + 1);
        if (p != null)
            _tip.SetToolTip(this, $"{_mois[idx]}\nRecettes : {Fmt.Fcfa(p.Recettes)}\nDépenses : {Fmt.Fcfa(p.Depenses)}\nRésultat : {Fmt.Fcfa(p.Recettes - p.Depenses)}");
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing) _tip.Dispose();
        base.Dispose(disposing);
    }
}

/// <summary>Anneau de répartition par catégorie avec légende.</summary>
public class GraphiqueDonut : ControleGraphique
{
    List<PartCategorie> _d = new();
    static readonly Color[] Palette =
    {
        Color.FromArgb(4, 120, 87), Color.FromArgb(212, 175, 55), Color.FromArgb(16, 185, 129),
        Color.FromArgb(13, 148, 136), Color.FromArgb(161, 126, 24), Color.FromArgb(110, 231, 183), Color.FromArgb(156, 163, 175)
    };

    public string LibelleCentre { get; set; } = "Total";
    public List<PartCategorie> Donnees { get => _d; set { _d = value ?? new(); Invalidate(); } }

    List<PartCategorie> Regrouper()
    {
        var tri = _d.Where(x => x.Total > 0).OrderByDescending(x => x.Total).ToList();
        if (tri.Count <= 6) return tri;
        var res = tri.Take(6).ToList();
        res.Add(new PartCategorie { Libelle = "Autres", Total = tri.Skip(6).Sum(x => x.Total) });
        return res;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        Theme.Lisser(g);
        var parts = Regrouper();
        decimal total = parts.Sum(p => p.Total);
        if (total <= 0) { Vide(g); return; }

        int side = Math.Min(Height - S(16), (int)(Width * 0.46));
        if (side < S(60)) return;
        var rect = new Rectangle(S(8), (Height - side) / 2, side, side);
        float th = side * 0.2f;
        var ring = Rectangle.Inflate(rect, -(int)(th / 2), -(int)(th / 2));

        float start = -90f;
        for (int i = 0; i < parts.Count; i++)
        {
            float sweep = (float)(parts[i].Total / total * 360m);
            using var pen = new Pen(Palette[i % Palette.Length], th);
            g.DrawArc(pen, ring, start, Math.Max(sweep - 2f, 0.6f));
            start += sweep;
        }

        var fl = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding;
        TextRenderer.DrawText(g, Fmt.Court(total), Theme.Police(13f, FontStyle.Bold), new Rectangle(rect.X, rect.Y + side / 2 - S(22), side, S(28)), Theme.Texte, fl);
        TextRenderer.DrawText(g, LibelleCentre, Theme.Police(9f), new Rectangle(rect.X, rect.Y + side / 2 + S(2), side, S(22)), Theme.TexteDoux, fl);

        int x0 = rect.Right + S(22), rowH = S(28);
        int y0 = Math.Max(4, (Height - parts.Count * rowH) / 2);
        for (int i = 0; i < parts.Count; i++)
        {
            int y = y0 + i * rowH;
            using (var b = new SolidBrush(Palette[i % Palette.Length])) g.FillEllipse(b, x0, y + S(8), S(11), S(11));
            int wTxt = Math.Max(S(30), Width - x0 - S(18) - S(60));
            TextRenderer.DrawText(g, parts[i].Libelle, Theme.Police(9.5f), new Rectangle(x0 + S(18), y, wTxt, rowH), Theme.Texte,
                TextFormatFlags.NoPadding | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
            TextRenderer.DrawText(g, (parts[i].Total / total * 100m).ToString("0.#") + " %", Theme.Police(9.5f, FontStyle.Bold),
                new Rectangle(Width - S(62), y, S(60), rowH), Theme.TexteDoux, TextFormatFlags.NoPadding | TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
    }
}

public class ElementBarre
{
    public string Libelle { get; set; } = string.Empty;
    public decimal Valeur { get; set; }
}

/// <summary>Barres horizontales de classement (ex. dépenses par centre d'imputation).</summary>
public class GraphiqueBarresH : ControleGraphique
{
    List<ElementBarre> _d = new();
    public Color Couleur { get; set; } = Theme.Or;
    public List<ElementBarre> Donnees { get => _d; set { _d = value ?? new(); Invalidate(); } }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        Theme.Lisser(g);
        var items = _d.Where(x => x.Valeur > 0).Take(6).ToList();
        if (items.Count == 0) { Vide(g); return; }

        decimal max = items.Max(x => x.Valeur);
        int rowH = Math.Min(S(46), Math.Max(S(32), (Height - 8) / items.Count));
        int labelW = (int)Math.Min(S(150), Width * 0.34);
        int trackW = Math.Max(S(20), Width - labelW - S(90));
        int y0 = Math.Max(2, (Height - items.Count * rowH) / 2);

        for (int i = 0; i < items.Count; i++)
        {
            int y = y0 + i * rowH;
            TextRenderer.DrawText(g, items[i].Libelle, Theme.Police(9.5f), new Rectangle(0, y, labelW - 8, rowH), Theme.Texte,
                TextFormatFlags.NoPadding | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
            var track = new RectangleF(labelW, y + rowH / 2f - S(7f), trackW, S(14f));
            using (var p = Theme.Arrondi(track, S(7f))) using (var b = new SolidBrush(Theme.Emeraude50)) g.FillPath(b, p);
            float w = Math.Max(S(10f), (float)(items[i].Valeur / max) * trackW);
            var fill = new RectangleF(track.X, track.Y, w, track.Height);
            using (var p = Theme.Arrondi(fill, S(7f)))
            using (var lb = new LinearGradientBrush(fill, Color.FromArgb(240, 214, 120), Couleur, LinearGradientMode.Horizontal))
                g.FillPath(lb, p);
            TextRenderer.DrawText(g, Fmt.Court(items[i].Valeur), Theme.Police(9.5f, FontStyle.Bold),
                new Rectangle(labelW + trackW + S(8), y, S(80), rowH), Theme.TexteDoux, TextFormatFlags.NoPadding | TextFormatFlags.VerticalCenter);
        }
    }
}
