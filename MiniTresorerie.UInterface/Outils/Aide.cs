using MiniTresorerie.Models;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Petites méthodes communes aux formulaires (mode d'appel, validation, tri des grilles…).</summary>
public static class Aide
{
    /// <summary>Prépare une fenêtre de détail selon le mode : titre, libellés des boutons, verrouillage des champs.</summary>
    public static void Preparer(ModeAppel mode, string entite, Label lblTitre, Button btnEnregistrer, Button btnFermer, Control corps)
    {
        lblTitre.Text = mode switch
        {
            ModeAppel.AJOUT => "Nouveau : " + entite,
            ModeAppel.MODIFICATION => "Modifier : " + entite,
            ModeAppel.CONSULTATION => "Consultation : " + entite,
            _ => "Suppression : " + entite
        };
        switch (mode)
        {
            case ModeAppel.AJOUT:
                btnEnregistrer.Text = "Enregistrer";
                btnFermer.Text = "Annuler";
                break;
            case ModeAppel.MODIFICATION:
                btnEnregistrer.Text = "Mettre à jour";
                btnFermer.Text = "Annuler";
                break;
            case ModeAppel.CONSULTATION:
                btnEnregistrer.Visible = false;
                Verrouiller(corps);
                break;
            case ModeAppel.SUPPRESSION:
                btnEnregistrer.Text = "Supprimer";
                btnEnregistrer.BackColor = Theme.Rouge;
                btnEnregistrer.FlatAppearance.MouseOverBackColor = Color.FromArgb(239, 68, 68);
                btnEnregistrer.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 28, 28);
                btnFermer.Text = "Annuler";
                Verrouiller(corps);
                break;
        }
    }

    /// <summary>Rend les champs en lecture seule (consultation et suppression).</summary>
    public static void Verrouiller(Control parent)
    {
        foreach (Control c in parent.Controls)
        {
            if (c is TextBox t) { t.ReadOnly = true; t.BackColor = Theme.Emeraude50; }
            else if (c is ComboBox || c is DateTimePicker || c is NumericUpDown || c is CheckBox) c.Enabled = false;
            else if (c.HasChildren) Verrouiller(c);
        }
    }

    /// <summary>Vérifie qu'un champ obligatoire est renseigné ; sinon affiche un message et place le curseur dessus.</summary>
    public static bool Requis(Control c, string nom)
    {
        bool vide = c switch
        {
            TextBox t => string.IsNullOrWhiteSpace(t.Text),
            ComboBox cb => cb.SelectedItem == null,
            NumericUpDown n => n.Value <= 0,
            _ => false
        };
        if (!vide) return true;
        MessageBox.Show($"Le champ « {nom} » est obligatoire.", "Contrôle de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        c.Focus();
        return false;
    }

    public static bool ConfirmerSuppression(string designation) =>
        MessageBox.Show($"Supprimer définitivement {designation} ?\nCette action est irréversible.", "Confirmation de suppression",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes;

    /// <summary>Sélectionne dans une liste déroulante l'élément qui répond au critère.</summary>
    public static void Choisir<T>(ComboBox cb, Func<T, bool> critere)
    {
        foreach (var o in cb.Items)
            if (o is T t && critere(t)) { cb.SelectedItem = o; return; }
    }

    /// <summary>Aligne les en-têtes des colonnes numériques comme leurs valeurs (à droite).</summary>
    public static void AlignerEntetes(DataGridView g)
    {
        foreach (DataGridViewColumn c in g.Columns)
            if (c.DefaultCellStyle.Alignment == DataGridViewContentAlignment.MiddleRight)
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
    }

    /// <summary>Réduit la police d'une étiquette tant que son texte dépasse sa largeur (montants longs des indicateurs).</summary>
    public static void AjusterPolice(Label l, float tailleMax, float tailleMin = 11f)
    {
        float t = tailleMax;
        Font? f = null;
        while (t >= tailleMin)
        {
            f?.Dispose();
            f = new Font(l.Font.FontFamily, t, l.Font.Style, GraphicsUnit.Point);
            if (TextRenderer.MeasureText(l.Text, f).Width <= l.ClientSize.Width - l.Padding.Horizontal) break;
            t -= 1f;
        }
        if (f != null) l.Font = f;
    }
}

/// <summary>Tri d'une liste par clic sur l'en-tête d'une colonne (croissant puis décroissant).</summary>
public class TriListe<T>
{
    bool _croissant = true;
    string? _colonne;

    public List<T> Trier(List<T> liste, string propriete)
    {
        var pi = typeof(T).GetProperty(propriete);
        if (pi == null || liste.Count == 0) return liste;
        _croissant = _colonne == propriete ? !_croissant : true;
        _colonne = propriete;
        return (_croissant ? liste.OrderBy(x => pi.GetValue(x)) : liste.OrderByDescending(x => pi.GetValue(x))).ToList();
    }
}
