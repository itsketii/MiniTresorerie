using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace MiniTresorerie.UInterface.Composants;

/// <summary>Logo vectoriel dessiné en GDI+ : pièce dorée, disque émeraude, barres ascendantes.</summary>
public static class Logo
{
    static Icon? _icone;

    public static void Dessiner(Graphics g, Rectangle r)
    {
        Theme.Lisser(g);
        using (var br = new LinearGradientBrush(r, Color.FromArgb(246, 219, 120), Theme.OrFonce, 45f))
            g.FillEllipse(br, r);
        var inner = Rectangle.Inflate(r, -(int)(r.Width * 0.09), -(int)(r.Height * 0.09));
        using (var br = new LinearGradientBrush(inner, Theme.Emeraude600, Theme.Emeraude950, 60f))
            g.FillEllipse(br, inner);

        float w = inner.Width, h = inner.Height;
        float bw = w * 0.12f, gap = w * 0.05f;
        float x0 = inner.X + (w - (3 * bw + 2 * gap)) / 2f;
        float baseY = inner.Y + h * 0.70f;
        float[] hs = { 0.18f, 0.30f, 0.44f };
        using var brB = new SolidBrush(Color.FromArgb(250, 232, 150));
        for (int i = 0; i < 3; i++)
        {
            var rb = new RectangleF(x0 + i * (bw + gap), baseY - h * hs[i], bw, h * hs[i]);
            using var p = Theme.ArrondiHaut(rb, bw / 3f);
            g.FillPath(brB, p);
        }
        using var pen = new Pen(Color.FromArgb(150, Theme.Or), Math.Max(1f, w * 0.02f));
        g.DrawLine(pen, inner.X + w * 0.2f, baseY + h * 0.05f, inner.Right - w * 0.2f, baseY + h * 0.05f);
    }

    public static Icon Icone()
    {
        if (_icone != null) return _icone;
        using var bmp = new Bitmap(64, 64);
        using (var g = Graphics.FromImage(bmp)) Dessiner(g, new Rectangle(2, 2, 60, 60));
        _icone = Icon.FromHandle(bmp.GetHicon());
        return _icone;
    }
}

/// <summary>Permet de déplacer une fenêtre sans bordure en glissant un contrôle.</summary>
public static class Deplacement
{
    [DllImport("user32.dll")] static extern bool ReleaseCapture();
    [DllImport("user32.dll")] static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

    public static void Activer(Control c)
    {
        c.MouseDown += (s, e) =>
        {
            if (e.Button != MouseButtons.Left) return;
            var f = c.FindForm();
            if (f == null) return;
            ReleaseCapture();
            SendMessage(f.Handle, 0xA1, 0x2, 0);
        };
    }
}
