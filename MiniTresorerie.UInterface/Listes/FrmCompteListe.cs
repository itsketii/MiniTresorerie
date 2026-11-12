using MiniTresorerie.DataAccess;
using MiniTresorerie.Models;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Comptes de trésorerie : recherche, ajout, modification, consultation, suppression, impression et exports PDF / Excel.</summary>
public partial class FrmCompteListe : Form
{
    List<CompteTresorerie> _donnees = new();
    readonly TriListe<CompteTresorerie> _tri = new();
    static readonly Font _gras = new Font("Segoe UI", 10F, FontStyle.Bold);

    public FrmCompteListe()
    {
        InitializeComponent();
        Aide.AlignerEntetes(dgv);
    }

    void FrmCompteListe_Load(object? sender, EventArgs e)
    {
        bool ecriture = Session.PeutEcrire;
        btnNouveau.Visible = btnModifier.Visible = btnSupprimer.Visible = ecriture;
        Charger();
    }

    // ------------------------------------------------------------------ chargement
    void Charger()
    {
        try
        {
            string filtre = txtRecherche.Text.Trim();
            _donnees = CompteTresorerieDAO.ReadAll(filtre);
            Afficher();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Erreur de chargement", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    void Afficher()
    {
        dgv.DataSource = null;
        dgv.DataSource = _donnees;
        decimal total = _donnees.Where(c => c.CptActif).Sum(c => c.CptSolde);
        lblPied.Text = $"{_donnees.Count} compte(s)   ·   Trésorerie totale (comptes actifs) : {Fmt.Fcfa(total)}";
    }

    CompteTresorerie? Selection => dgv.CurrentRow?.DataBoundItem as CompteTresorerie;

    void Agir(ModeAppel mode)
    {
        var element = Selection;
        if (element == null)
        {
            MessageBox.Show("Sélectionnez d'abord une ligne dans la liste.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        using var f = new FrmCompteDetail(element, mode);
        if (f.ShowDialog(this) == DialogResult.OK && mode != ModeAppel.CONSULTATION) Charger();
    }

    // ------------------------------------------------------------------ événements
    void txtRecherche_TextChanged(object? sender, EventArgs e) => Charger();

    void btnNouveau_Click(object? sender, EventArgs e)
    {
        using var f = new FrmCompteDetail(null, ModeAppel.AJOUT);
        if (f.ShowDialog(this) == DialogResult.OK) Charger();
    }

    void btnModifier_Click(object? sender, EventArgs e) => Agir(ModeAppel.MODIFICATION);
    void btnConsulter_Click(object? sender, EventArgs e) => Agir(ModeAppel.CONSULTATION);
    void btnSupprimer_Click(object? sender, EventArgs e) => Agir(ModeAppel.SUPPRESSION);
    void btnActualiser_Click(object? sender, EventArgs e) => Charger();
    void btnImprimer_Click(object? sender, EventArgs e) => ImpressionGrille.Apercu(dgv, Text);
    void btnPdf_Click(object? sender, EventArgs e) => ImpressionGrille.Pdf(dgv, Text);
    void btnExcel_Click(object? sender, EventArgs e) => Exporteur.Csv(dgv, Text);

    void dgv_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) Agir(ModeAppel.CONSULTATION);
    }

    void dgv_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
    {
        _donnees = _tri.Trier(_donnees, dgv.Columns[e.ColumnIndex].DataPropertyName);
        Afficher();
    }

    void dgv_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0) return;
        string p = dgv.Columns[e.ColumnIndex].DataPropertyName;
        if (p == nameof(CompteTresorerie.CptSolde))
        {
            bool negatif = Convert.ToDecimal(e.Value ?? 0m) < 0;
            e.CellStyle.ForeColor = negatif ? Theme.Rouge : Theme.Emeraude700;
            e.CellStyle.Font = _gras;
        }
        else if (p == nameof(CompteTresorerie.Statut))
        {
            e.CellStyle.ForeColor = Convert.ToString(e.Value) == "Actif" ? Theme.Emeraude700 : Theme.TexteDoux;
        }
    }
}
