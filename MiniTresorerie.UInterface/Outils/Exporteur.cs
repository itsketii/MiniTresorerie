using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace MiniTresorerie.UInterface;

/// <summary>Export du contenu d'une grille vers un fichier CSV lisible par Excel (séparateur « ; », UTF-8 avec BOM).</summary>
public static class Exporteur
{
    static readonly CultureInfo Fr = new CultureInfo("fr-FR");

    public static string NomFichier(string titre)
    {
        var s = new string(titre.Select(c => char.IsLetterOrDigit(c) ? c : '_').ToArray());
        while (s.Contains("__")) s = s.Replace("__", "_");
        return s.Trim('_');
    }

    public static void Csv(DataGridView g, string titre)
    {
        if (g.Rows.Count == 0) { MessageBox.Show("Aucune donnée à exporter.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
        using var sfd = new SaveFileDialog
        {
            Title = "Exporter vers Excel",
            Filter = "Fichier Excel / CSV (*.csv)|*.csv",
            FileName = $"{NomFichier(titre)}_{DateTime.Now:yyyyMMdd_HHmm}.csv"
        };
        if (sfd.ShowDialog() != DialogResult.OK) return;
        try
        {
            var cols = g.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible).OrderBy(c => c.DisplayIndex).ToList();
            var sb = new StringBuilder();
            sb.AppendLine(string.Join(";", cols.Select(c => Echapper(c.HeaderText))));
            foreach (DataGridViewRow row in g.Rows)
            {
                if (!row.Visible) continue;
                sb.AppendLine(string.Join(";", cols.Select(c => Echapper(Valeur(row.Cells[c.Index])))));
            }
            File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true));
            if (MessageBox.Show("Export terminé.\nOuvrir le fichier maintenant ?", "Export Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
        }
        catch (Exception ex)
        {
            MessageBox.Show("Export impossible : " + ex.Message, "Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    static string Valeur(DataGridViewCell c) => c.Value switch
    {
        null => "",
        decimal d => d.ToString("0.##", Fr),
        int i => i.ToString(),
        DateTime dt => dt.ToString("dd/MM/yyyy"),
        bool b => b ? "Oui" : "Non",
        _ => c.FormattedValue?.ToString() ?? ""
    };

    static string Echapper(string s)
    {
        if (s.IndexOfAny(new[] { ';', '"', '\n', '\r' }) >= 0) return "\"" + s.Replace("\"", "\"\"") + "\"";
        return s;
    }
}
