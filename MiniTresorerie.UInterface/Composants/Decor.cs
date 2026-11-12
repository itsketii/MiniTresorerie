using System.Drawing.Drawing2D;

namespace MiniTresorerie.UInterface.Composants;

// Petits contrôles purement décoratifs (formes uniquement, aucun texte dessiné).
// Toutes les dimensions sont proportionnelles à la taille du contrôle : l'affichage reste correct
// quelle que soit la mise à l'échelle de Windows (100 %, 125 %, 150 %…).

/// <summary>Logo de l'application (pièce dorée, disque émeraude, barres ascendantes).</summary>
public class LogoControl : Control
{
    public LogoControl()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.SupportsTransparentBackColor | ControlStyles.ResizeRedraw, true);
        BackColor = Color.Transparent;
        Size = new Size(48, 48);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        if (Width < 4 || Height < 4) return;
        Logo.Dessiner(e.Graphics, new Rectangle(0, 0, Width - 1, Height - 1));
    }
}

/// <summary>Petite pastille ronde avec une coche (liste d'avantages de l'écran de connexion).</summary>
public class PuceCoche : Control
{
    public PuceCoche()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.SupportsTransparentBackColor | ControlStyles.ResizeRedraw, true);
        BackColor = Color.Transparent;
        Size = new Size(22, 22);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        Theme.Lisser(g);
        float w = Width - 1, h = Height - 1;
        using (var b = new SolidBrush(Color.FromArgb(60, Theme.Or))) g.FillEllipse(b, 0, 0, w, h);
        using var pen = new Pen(Theme.Or, Math.Max(1.5f, w * 0.09f)) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round };
        g.DrawLines(pen, new[] { new PointF(w * 0.28f, h * 0.52f), new PointF(w * 0.44f, h * 0.68f), new PointF(w * 0.74f, h * 0.34f) });
    }
}

/// <summary>Barre de progression arrondie, dégradé doré (écran de démarrage).</summary>
public class BarreProgression : Control
{
    float _valeur;

    /// <summary>Progression de 0 à 100.</summary>
    public float Valeur { get => _valeur; set { _valeur = Math.Max(0f, Math.Min(100f, value)); Invalidate(); } }

    public BarreProgression()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.SupportsTransparentBackColor | ControlStyles.ResizeRedraw, true);
        BackColor = Color.Transparent;
        Size = new Size(400, 8);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        Theme.Lisser(g);
        var piste = new RectangleF(0, 0, Width - 1, Height - 1);
        if (piste.Width < 4 || piste.Height < 2) return;
        float r = piste.Height / 2f;
        using (var p = Theme.Arrondi(piste, r)) using (var b = new SolidBrush(Color.FromArgb(50, 255, 255, 255))) g.FillPath(b, p);
        float w = Math.Max(piste.Height, piste.Width * _valeur / 100f);
        var rempli = new RectangleF(0, 0, w, piste.Height);
        using (var p = Theme.Arrondi(rempli, r))
        using (var b = new LinearGradientBrush(rempli, Color.FromArgb(240, 214, 120), Theme.Or, 0f))
            g.FillPath(b, p);
    }
}

/// <summary>Fond de l'écran de démarrage : dégradé émeraude et disques translucides (proportionnels).</summary>
public class PanneauSplash : PanelDegrade
{
    public PanneauSplash()
    {
        Debut = Theme.Emeraude950;
        Fin = Theme.Emeraude700;
        Angle = 40f;
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        base.OnPaintBackground(e);
        if (Width <= 0 || Height <= 0) return;
        var g = e.Graphics;
        Theme.Lisser(g);
        float w = Width, h = Height;
        using (var b = new SolidBrush(Color.FromArgb(14, 255, 255, 255)))
        {
            g.FillEllipse(b, -w * 0.125f, -h * 0.32f, w * 0.53f, h * 0.9f);
            g.FillEllipse(b, w * 0.67f, h * 0.5f, w * 0.52f, h * 0.87f);
            g.FillEllipse(b, w * 0.47f, -h * 0.24f, w * 0.25f, h * 0.42f);
        }
        using (var b = new SolidBrush(Color.FromArgb(40, Theme.Or))) g.FillEllipse(b, w * 0.06f, h * 0.68f, w * 0.19f, h * 0.32f);
    }
}

/// <summary>Panneau d'illustration de l'écran de connexion : dégradé, disques et mini-histogramme avec courbe dorée.</summary>
public class PanneauIllustration : PanelDegrade
{
    public PanneauIllustration()
    {
        Debut = Theme.Emeraude950;
        Fin = Theme.Emeraude700;
        Angle = 55f;
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        base.OnPaintBackground(e);
        if (Width <= 0 || Height <= 0) return;
        var g = e.Graphics;
        Theme.Lisser(g);
        // Dessin conçu sur une base de 500 x 600 puis mis à l'échelle du contrôle.
        float fx = Width / 500f, fy = Height / 600f;
        using (var b = new SolidBrush(Color.FromArgb(14, 255, 255, 255)))
        {
            g.FillEllipse(b, -120 * fx, -140 * fy, 420 * fx, 420 * fy);
            g.FillEllipse(b, 260 * fx, 330 * fy, 380 * fx, 380 * fy);
            g.FillEllipse(b, 330 * fx, 20 * fy, 180 * fx, 180 * fy);
        }
        using (var b = new SolidBrush(Color.FromArgb(38, Theme.Or))) g.FillEllipse(b, 380 * fx, 250 * fy, 90 * fx, 90 * fy);

        var carte = new RectangleF(40 * fx, 380 * fy, 420 * fx, 180 * fy);
        using (var p = Theme.Arrondi(carte, 18 * fx))
        {
            using var b = new SolidBrush(Color.FromArgb(24, 255, 255, 255));
            g.FillPath(b, p);
            using var pen = new Pen(Color.FromArgb(40, 255, 255, 255));
            g.DrawPath(pen, p);
        }
        float[] hs = { 34, 56, 44, 78, 64, 98, 86, 122 };
        float bw = 28 * fx, gap = 17 * fx, x0 = carte.X + 28 * fx, baseY = carte.Bottom - 22 * fy;
        var pts = new List<PointF>();
        for (int i = 0; i < hs.Length; i++)
        {
            var rb = new RectangleF(x0 + i * (bw + gap), baseY - hs[i] * fy, bw, hs[i] * fy);
            using var path = Theme.ArrondiHaut(rb, 6 * fx);
            using var br = new SolidBrush(i >= hs.Length - 2 ? Theme.Or : Color.FromArgb(80, 255, 255, 255));
            g.FillPath(br, path);
            pts.Add(new PointF(rb.X + bw / 2, rb.Y - 14 * fy));
        }
        using (var pen = new Pen(Color.FromArgb(240, 214, 120), Math.Max(2f, 2.5f * fx))) g.DrawCurve(pen, pts.ToArray(), 0.4f);
        foreach (var pt in pts)
        {
            using var b = new SolidBrush(Theme.Or);
            float r = 4 * fx;
            g.FillEllipse(b, pt.X - r, pt.Y - r, 2 * r, 2 * r);
        }
    }
}
