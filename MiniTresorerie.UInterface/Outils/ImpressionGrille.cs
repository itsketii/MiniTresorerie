using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Impression / aperçu / export PDF de n'importe quelle grille (en-tête aux couleurs de l'application, pagination).</summary>
public class ImpressionGrille
{
    readonly DataGridView _g;
    readonly string _titre, _sous;
    List<DataGridViewColumn> _cols = new();
    int _ligne, _page;

    ImpressionGrille(DataGridView g, string titre, string? sousTitre)
    {
        _g = g;
        _titre = titre;
        _sous = sousTitre ?? $"Édité le {DateTime.Now:dd/MM/yyyy à HH:mm} par {Session.Utilisateur?.NomComplet}";
    }

    public static void Apercu(DataGridView g, string titre, string? sousTitre = null)
    {
        if (g.Rows.Count == 0) { MessageBox.Show("Aucune donnée à imprimer.", "Impression", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
        using var dlg = new PrintPreviewDialog
        {
            Document = new ImpressionGrille(g, titre, sousTitre).Creer(),
            WindowState = FormWindowState.Maximized,
            UseAntiAlias = true
        };
        dlg.ShowDialog();
    }

    /// <summary>Exporte en PDF via l'imprimante virtuelle « Microsoft Print to PDF » (Windows 10/11).</summary>
    public static void Pdf(DataGridView g, string titre, string? sousTitre = null)
    {
        if (g.Rows.Count == 0) { MessageBox.Show("Aucune donnée à exporter.", "Export PDF", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
        using var sfd = new SaveFileDialog
        {
            Title = "Exporter en PDF",
            Filter = "Document PDF (*.pdf)|*.pdf",
            FileName = $"{Exporteur.NomFichier(titre)}_{DateTime.Now:yyyyMMdd_HHmm}.pdf"
        };
        if (sfd.ShowDialog() != DialogResult.OK) return;
        try
        {
            var doc = new ImpressionGrille(g, titre, sousTitre).Creer();
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            doc.PrinterSettings.PrintToFile = true;
            doc.PrinterSettings.PrintFileName = sfd.FileName;
            if (!doc.PrinterSettings.IsValid)
            {
                MessageBox.Show("L'imprimante « Microsoft Print to PDF » est introuvable.\nUtilisez l'aperçu avant impression puis choisissez une imprimante PDF.",
                    "Export PDF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            doc.Print();
            if (MessageBox.Show("PDF créé.\nOuvrir le fichier maintenant ?", "Export PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
        }
        catch (Exception ex)
        {
            MessageBox.Show("Export PDF impossible : " + ex.Message, "Export PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    PrintDocument Creer()
    {
        var doc = new PrintDocument { DocumentName = _titre };
        doc.DefaultPageSettings.Landscape = _g.Columns.Cast<DataGridViewColumn>().Count(c => c.Visible) > 5;
        doc.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);
        doc.BeginPrint += (s, e) =>
        {
            _ligne = 0;
            _page = 0;
            _cols = _g.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible).OrderBy(c => c.DisplayIndex).ToList();
        };
        doc.PrintPage += ImprimerPage;
        return doc;
    }

    void ImprimerPage(object sender, PrintPageEventArgs e)
    {
        var g = e.Graphics!;
        Theme.Lisser(g);
        _page++;
        var m = e.MarginBounds;
        float y = m.Top;

        using (var b = new SolidBrush(Theme.Emeraude900)) g.FillRectangle(b, m.Left, y, m.Width, 44);
        using (var b = new SolidBrush(Theme.Or)) g.FillRectangle(b, m.Left, y + 44, m.Width, 4);
        using (var f = new Font("Segoe UI", 15, FontStyle.Bold))
            g.DrawString("MINI TRÉSORERIE", f, Brushes.White, m.Left + 12, y + 8);
        using (var f = new Font("Segoe UI", 9))
        {
            var sf = new StringFormat { Alignment = StringAlignment.Far };
            g.DrawString("Gestion de trésorerie", f, Brushes.White, new RectangleF(m.Left, y + 14, m.Width - 12, 20), sf);
        }
        y += 62;
        using (var f = new Font("Segoe UI", 14, FontStyle.Bold))
        using (var b = new SolidBrush(Theme.Emeraude900))
            g.DrawString(_titre, f, b, m.Left, y);
        y += 26;
        using (var f = new Font("Segoe UI", 9))
            g.DrawString(_sous, f, Brushes.Gray, m.Left, y);
        y += 28;

        float total = _cols.Sum(c => (float)c.Width);
        float scale = m.Width / Math.Max(1f, total);
        float rh = 24;
        using var fEnt = new Font("Segoe UI", 8.5f, FontStyle.Bold);
        using var fTxt = new Font("Segoe UI", 8.5f);

        float x = m.Left;
        using (var b = new SolidBrush(Theme.Emeraude700)) g.FillRectangle(b, m.Left, y, m.Width, rh + 2);
        foreach (var c in _cols)
        {
            float w = c.Width * scale;
            var sf = Format(c);
            g.DrawString(c.HeaderText, fEnt, Brushes.White, new RectangleF(x + 4, y, w - 8, rh + 2), sf);
            x += w;
        }
        y += rh + 2;

        while (_ligne < _g.Rows.Count && y + rh <= m.Bottom - 24)
        {
            var row = _g.Rows[_ligne];
            _ligne++;
            if (!row.Visible) continue;
            if (_ligne % 2 == 0)
                using (var b = new SolidBrush(Theme.Emeraude50)) g.FillRectangle(b, m.Left, y, m.Width, rh);
            x = m.Left;
            foreach (var c in _cols)
            {
                float w = c.Width * scale;
                string txt = row.Cells[c.Index].FormattedValue?.ToString() ?? "";
                g.DrawString(txt, fTxt, Brushes.Black, new RectangleF(x + 4, y, w - 8, rh), Format(c));
                x += w;
            }
            using (var p = new Pen(Theme.Bordure)) g.DrawLine(p, m.Left, y + rh, m.Right, y + rh);
            y += rh;
        }

        using (var f = new Font("Segoe UI", 8))
        {
            var sf = new StringFormat { Alignment = StringAlignment.Far };
            g.DrawString($"Page {_page}", f, Brushes.Gray, new RectangleF(m.Left, m.Bottom - 14, m.Width, 14), sf);
            g.DrawString("Mini Trésorerie — document généré automatiquement", f, Brushes.Gray, m.Left, m.Bottom - 14);
        }
        e.HasMorePages = _ligne < _g.Rows.Count;
    }

    static StringFormat Format(DataGridViewColumn c)
    {
        var al = c.DefaultCellStyle.Alignment;
        bool droite = al == DataGridViewContentAlignment.MiddleRight || al == DataGridViewContentAlignment.TopRight || al == DataGridViewContentAlignment.BottomRight;
        return new StringFormat
        {
            Alignment = droite ? StringAlignment.Far : StringAlignment.Near,
            LineAlignment = StringAlignment.Center,
            Trimming = StringTrimming.EllipsisCharacter,
            FormatFlags = StringFormatFlags.NoWrap
        };
    }
}
