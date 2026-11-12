using System.Drawing.Printing;
using MiniTresorerie.Models;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Reçu d'encaissement / bon de décaissement imprimable pour un mouvement.</summary>
public static class ImpressionRecu
{
    public static void Apercu(Mouvement mvt)
    {
        var doc = new PrintDocument { DocumentName = "Reçu " + mvt.MvtReference };
        doc.DefaultPageSettings.Margins = new Margins(60, 60, 60, 60);
        doc.PrintPage += (s, e) => Dessiner(e, mvt);
        using var dlg = new PrintPreviewDialog { Document = doc, WindowState = FormWindowState.Maximized, UseAntiAlias = true };
        dlg.ShowDialog();
    }

    static void Dessiner(PrintPageEventArgs e, Mouvement m)
    {
        var g = e.Graphics!;
        Theme.Lisser(g);
        var r = e.MarginBounds;
        float y = r.Top;
        bool rec = m.EstRecette;

        using (var b = new SolidBrush(Theme.Emeraude900)) g.FillRectangle(b, r.Left, y, r.Width, 70);
        using (var b = new SolidBrush(Theme.Or)) g.FillRectangle(b, r.Left, y + 70, r.Width, 5);
        Logo.Dessiner(g, new Rectangle(r.Left + 12, (int)y + 9, 52, 52));
        using (var f = new Font("Segoe UI", 16, FontStyle.Bold)) g.DrawString("MINI TRÉSORERIE", f, Brushes.White, r.Left + 74, y + 8);
        using (var f = new Font("Segoe UI", 9)) g.DrawString("Gestion de trésorerie et suivi analytique", f, Brushes.White, r.Left + 76, y + 38);
        var sfD = new StringFormat { Alignment = StringAlignment.Far };
        using (var f = new Font("Segoe UI", 13, FontStyle.Bold))
            g.DrawString(rec ? "REÇU D'ENCAISSEMENT" : "BON DE DÉCAISSEMENT", f, Brushes.White, new RectangleF(r.Left, y + 10, r.Width - 14, 26), sfD);
        using (var f = new Font("Segoe UI", 10))
        {
            g.DrawString("N° " + m.MvtReference, f, Brushes.White, new RectangleF(r.Left, y + 36, r.Width - 14, 20), sfD);
            g.DrawString("Date : " + m.MvtDate.ToString("dd/MM/yyyy"), f, Brushes.White, new RectangleF(r.Left, y + 52, r.Width - 14, 20), sfD);
        }
        y += 100;

        var lignes = new (string, string)[]
        {
            ("Libellé", m.MvtLibelle),
            (rec ? "Reçu de" : "Payé à", string.IsNullOrWhiteSpace(m.MvtTiers) ? "—" : m.MvtTiers!),
            ("Compte de trésorerie", m.Compte),
            ("Catégorie", m.CatLibelle),
            ("Centre d'imputation", m.Centre),
            ("Mode de paiement", m.MpLibelle),
            ("Pièce justificative", string.IsNullOrWhiteSpace(m.MvtPiece) ? "—" : m.MvtPiece!)
        };
        using var fl = new Font("Segoe UI", 10, FontStyle.Bold);
        using var fv = new Font("Segoe UI", 10.5f);
        using var pen = new Pen(Theme.Bordure);
        foreach (var (lab, val) in lignes)
        {
            using (var b = new SolidBrush(Theme.Emeraude900)) g.DrawString(lab, fl, b, r.Left + 6, y);
            g.DrawString(val, fv, Brushes.Black, new RectangleF(r.Left + 190, y, r.Width - 196, 24), new StringFormat { Trimming = StringTrimming.EllipsisCharacter, FormatFlags = StringFormatFlags.NoWrap });
            y += 28;
            g.DrawLine(pen, r.Left, y - 4, r.Right, y - 4);
        }
        y += 16;

        var boite = new RectangleF(r.Left, y, r.Width, 84);
        using (var p = Theme.Arrondi(boite, 12))
        {
            using var b = new SolidBrush(Theme.OrClair);
            g.FillPath(b, p);
            using var pb = new Pen(Theme.Or, 2f);
            g.DrawPath(pb, p);
        }
        using (var f = new Font("Segoe UI", 10)) g.DrawString("MONTANT", f, Brushes.DimGray, boite.Left + 16, boite.Top + 10);
        using (var f = new Font("Segoe UI", 24, FontStyle.Bold))
        using (var b = new SolidBrush(rec ? Theme.Emeraude700 : Theme.Rouge))
            g.DrawString(Fmt.Fcfa(m.MvtMontant), f, b, new RectangleF(boite.Left, boite.Top + 22, boite.Width - 16, 50), sfD);
        y += 100;

        string lettres = Nombre.EnLettres((long)Math.Round(m.MvtMontant)) + " francs CFA";
        using (var f = new Font("Segoe UI", 10, FontStyle.Italic))
            g.DrawString("Arrêté la présente somme à : " + lettres + ".", f, Brushes.Black, new RectangleF(r.Left, y, r.Width, 48));
        y += 70;

        using (var f = new Font("Segoe UI", 10, FontStyle.Bold))
        {
            g.DrawString(rec ? "Le caissier / comptable" : "Le comptable", f, Brushes.Black, r.Left + 10, y);
            g.DrawString(rec ? "Le déposant" : "Le bénéficiaire", f, Brushes.Black, new RectangleF(r.Left, y, r.Width - 10, 20), sfD);
        }
        using (var p = new Pen(Color.Gray) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
        {
            g.DrawRectangle(p, r.Left, y + 26, 230, 90);
            g.DrawRectangle(p, r.Right - 230, y + 26, 230, 90);
        }
        using (var f = new Font("Segoe UI", 8))
            g.DrawString($"Saisi par {m.UsrLogin} le {m.MvtDateSaisie:dd/MM/yyyy HH:mm} — Imprimé le {DateTime.Now:dd/MM/yyyy HH:mm}", f, Brushes.Gray, r.Left, r.Bottom - 14);
        e.HasMorePages = false;
    }
}
