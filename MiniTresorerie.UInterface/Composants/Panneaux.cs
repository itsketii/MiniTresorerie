using System.Drawing.Drawing2D;

namespace MiniTresorerie.UInterface.Composants;

/// <summary>Panneau avec dégradé de fond (barre latérale, en-têtes). Ne contient aucun texte dessiné : les libellés sont de vrais Label.</summary>
public class PanelDegrade : Panel
{
    public Color Debut { get; set; } = Theme.Emeraude950;
    public Color Fin { get; set; } = Theme.Emeraude900;
    public float Angle { get; set; } = 90f;

    public PanelDegrade()
    {
        DoubleBuffered = true;
        ResizeRedraw = true;
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        if (Width <= 0 || Height <= 0) return;
        using var lb = new LinearGradientBrush(ClientRectangle, Debut, Fin, Angle);
        e.Graphics.FillRectangle(lb, ClientRectangle);
    }
}
