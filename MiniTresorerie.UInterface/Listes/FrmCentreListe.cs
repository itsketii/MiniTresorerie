using MiniTresorerie.DataAccess;
using MiniTresorerie.Models;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Centres d'imputation analytique : recherche, ajout, modification, consultation, suppression, impression et exports PDF / Excel.</summary>
public partial class FrmCentreListe : Form
{
    List<CentreImputation> _donnees = new();
    readonly TriListe<CentreImputation> _tri = new();
    static readonly Font _gras = new Font("Segoe UI", 10F, FontStyle.Bold);

    public FrmCentreListe()
    {
        InitializeComponent();
        Aide.AlignerEntetes(dgv);
    }

    void FrmCentreListe_Load(object? sender, EventArgs e)
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
            _donnees = CentreImputationDAO.ReadAll(filtre);
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
        lblPied.Text = $"{_donnees.Count} centre(s)";
    }

    CentreImputation? Selection => dgv.CurrentRow?.DataBoundItem as CentreImputation;

    void Agir(ModeAppel mode)
    {
        var element = Selection;
        if (element == null)
        {
            MessageBox.Show("Sélectionnez d'abord une ligne dans la liste.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        using var f = new FrmCentreDetail(element, mode);
        if (f.ShowDialog(this) == DialogResult.OK && mode != ModeAppel.CONSULTATION) Charger();
    }

    // ------------------------------------------------------------------ événements
    void txtRecherche_TextChanged(object? sender, EventArgs e) => Charger();

    void btnNouveau_Click(object? sender, EventArgs e)
    {
        using var f = new FrmCentreDetail(null, ModeAppel.AJOUT);
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
        if (p == nameof(CentreImputation.Statut))
        {
            e.CellStyle.ForeColor = Convert.ToString(e.Value) == "Actif" ? Theme.Emeraude700 : Theme.TexteDoux;
            e.CellStyle.Font = _gras;
        }
    }
}
