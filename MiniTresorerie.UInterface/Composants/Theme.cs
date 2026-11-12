using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace MiniTresorerie.UInterface.Composants;

/// <summary>Charte graphique : vert émeraude + or, fond clair, cartes blanches arrondies.</summary>
public static class Theme
{
    public static readonly Color Emeraude950 = Color.FromArgb(2, 44, 34);
    public static readonly Color Emeraude900 = Color.FromArgb(6, 78, 59);
    public static readonly Color Emeraude700 = Color.FromArgb(4, 120, 87);
    public static readonly Color Emeraude600 = Color.FromArgb(5, 150, 105);
    public static readonly Color Emeraude500 = Color.FromArgb(16, 185, 129);
    public static readonly Color Emeraude100 = Color.FromArgb(209, 250, 229);
    public static readonly Color Emeraude50 = Color.FromArgb(236, 253, 245);
    public static readonly Color Or = Color.FromArgb(212, 175, 55);
    public static readonly Color OrFonce = Color.FromArgb(176, 140, 28);
    public static readonly Color OrClair = Color.FromArgb(253, 246, 220);
    public static readonly Color Fond = Color.FromArgb(243, 247, 245);
    public static readonly Color Texte = Color.FromArgb(17, 24, 39);
    public static readonly Color TexteDoux = Color.FromArgb(107, 114, 128);
    public static readonly Color Bordure = Color.FromArgb(226, 232, 229);
    public static readonly Color Rouge = Color.FromArgb(220, 38, 38);
    public static readonly Color RougeClair = Color.FromArgb(254, 226, 226);

    static readonly Dictionary<string, Font> _cache = new();

    public static Font Police(float taille, FontStyle style = FontStyle.Regular)
    {
        string cle = $"S|{taille}|{(int)style}";
        if (!_cache.TryGetValue(cle, out var f))
        {
            f = new Font("Segoe UI", taille, style, GraphicsUnit.Point);
            _cache[cle] = f;
        }
        return f;
    }

    public static void Lisser(Graphics g)
    {
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        g.PixelOffsetMode = PixelOffsetMode.HighQuality;
        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
    }

    public static GraphicsPath Arrondi(RectangleF r, float rayon)
    {
        var p = new GraphicsPath();
        if (rayon <= 0.5f || r.Width <= 1 || r.Height <= 1) { p.AddRectangle(r); return p; }
        float d = Math.Min(rayon * 2, Math.Min(r.Width, r.Height));
        p.AddArc(r.X, r.Y, d, d, 180, 90);
        p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
        p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
        p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
        p.CloseFigure();
        return p;
    }

    public static GraphicsPath ArrondiHaut(RectangleF r, float rayon)
    {
        var p = new GraphicsPath();
        float d = Math.Min(rayon * 2, Math.Min(r.Width, r.Height * 2));
        if (d < 2) { p.AddRectangle(r); return p; }
        p.AddArc(r.X, r.Y, d, d, 180, 90);
        p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
        p.AddLine(r.Right, r.Bottom, r.X, r.Bottom);
        p.CloseFigure();
        return p;
    }
}

public static class Fmt
{
    public static string Montant(decimal d) => d.ToString("#,##0") + " F";
    public static string Fcfa(decimal d) => d.ToString("#,##0") + " FCFA";

    public static string Court(decimal d)
    {
        decimal a = Math.Abs(d);
        if (a >= 1_000_000_000m) return (d / 1_000_000_000m).ToString("0.#") + " Md";
        if (a >= 1_000_000m) return (d / 1_000_000m).ToString("0.#") + " M";
        if (a >= 1_000m) return (d / 1_000m).ToString("0.#") + " k";
        return d.ToString("0");
    }
}
