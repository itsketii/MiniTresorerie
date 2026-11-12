using MiniTresorerie.DataAccess;
using MiniTresorerie.Models;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Journal des mouvements (recettes / dépenses) avec filtres par période, compte, type et état de pointage.</summary>
public partial class FrmMouvementListe : Form
{
    List<Mouvement> _donnees = new();
    readonly TriListe<Mouvement> _tri = new();
    static readonly Font _gras = new Font("Segoe UI", 10F, FontStyle.Bold);
    bool _init = true;

    public FrmMouvementListe()
    {
        InitializeComponent();
        Aide.AlignerEntetes(dgv);
    }

    void FrmMouvementListe_Load(object? sender, EventArgs e)
    {
        bool ecriture = Session.PeutEcrire;
        btnRecette.Visible = btnDepense.Visible = btnModifier.Visible = btnSupprimer.Visible = ecriture;
        try
        {
            cbCompte.Items.Add("Tous les comptes");
            foreach (var c in CompteTresorerieDAO.ReadAll("")) cbCompte.Items.Add(c);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Erreur de chargement", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        cbCompte.SelectedIndex = 0;
        cbType.SelectedIndex = 0;
        cbEtat.SelectedIndex = 0;
        _init = false;
        Charger();
    }

    // ------------------------------------------------------------------ chargement
    void Charger()
    {
        try
        {
            var f = new MouvementFiltre
            {
                Texte = txtRecherche.Text.Trim(),
                DateDebut = dtDebut.Checked ? dtDebut.Value.Date : null,
                DateFin = dtFin.Checked ? dtFin.Value.Date : null,
                CompteId = (cbCompte.SelectedItem as CompteTresorerie)?.CompteId,
                Type = cbType.SelectedIndex == 1 ? TypesMouvement.Recette : cbType.SelectedIndex == 2 ? TypesMouvement.Depense : null,
                Rapproche = cbEtat.SelectedIndex == 1 ? true : cbEtat.SelectedIndex == 2 ? false : (bool?)null
            };
            _donnees = MouvementDAO.ReadAll(f);
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
        decimal rec = _donnees.Where(m => m.EstRecette).Sum(m => m.MvtMontant);
        decimal dep = _donnees.Where(m => !m.EstRecette).Sum(m => m.MvtMontant);
        lblPied.Text = $"{_donnees.Count} mouvement(s)   ·   Recettes : {Fmt.Fcfa(rec)}   ·   Dépenses : {Fmt.Fcfa(dep)}   ·   Solde : {Fmt.Fcfa(rec - dep)}";
    }

    string SousTitre()
    {
        string periode = dtDebut.Checked || dtFin.Checked
            ? $"Période : {(dtDebut.Checked ? dtDebut.Value.ToString("dd/MM/yyyy") : "début")} au {(dtFin.Checked ? dtFin.Value.ToString("dd/MM/yyyy") : "ce jour")}   ·   "
            : "";
        return periode + $"Édité le {DateTime.Now:dd/MM/yyyy HH:mm} par {Session.Utilisateur?.NomComplet}";
    }

    Mouvement? Selection => dgv.CurrentRow?.DataBoundItem as Mouvement;

    Mouvement? ChoisirLigne()
    {
        var m = Selection;
        if (m == null)
            MessageBox.Show("Sélectionnez d'abord une ligne dans la liste.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return m;
    }

    void Agir(ModeAppel mode)
    {
        var m = ChoisirLigne();
        if (m == null) return;
        using var f = new FrmMouvementDetail(m, mode);
        if (f.ShowDialog(this) == DialogResult.OK && mode != ModeAppel.CONSULTATION) Charger();
    }

    void Nouveau(string type)
    {
        using var f = new FrmMouvementDetail(null, ModeAppel.AJOUT, type);
        if (f.ShowDialog(this) == DialogResult.OK) Charger();
    }

    // ------------------------------------------------------------------ événements
    void txtRecherche_TextChanged(object? sender, EventArgs e) { if (!_init) Charger(); }
    void Filtre_Changed(object? sender, EventArgs e) { if (!_init) Charger(); }
    void btnRecette_Click(object? sender, EventArgs e) => Nouveau(TypesMouvement.Recette);
    void btnDepense_Click(object? sender, EventArgs e) => Nouveau(TypesMouvement.Depense);
    void btnModifier_Click(object? sender, EventArgs e) => Agir(ModeAppel.MODIFICATION);
    void btnConsulter_Click(object? sender, EventArgs e) => Agir(ModeAppel.CONSULTATION);
    void btnSupprimer_Click(object? sender, EventArgs e) => Agir(ModeAppel.SUPPRESSION);
    void btnActualiser_Click(object? sender, EventArgs e) => Charger();

    void btnRecu_Click(object? sender, EventArgs e)
    {
        var m = ChoisirLigne();
        if (m != null) ImpressionRecu.Apercu(m);
    }

    void btnImprimer_Click(object? sender, EventArgs e) => ImpressionGrille.Apercu(dgv, Text, SousTitre());
    void btnPdf_Click(object? sender, EventArgs e) => ImpressionGrille.Pdf(dgv, Text, SousTitre());
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
        if (p == nameof(Mouvement.MontantSigne))
        {
            e.CellStyle.ForeColor = Convert.ToDecimal(e.Value ?? 0m) < 0 ? Theme.Rouge : Theme.Emeraude700;
            e.CellStyle.Font = _gras;
        }
        else if (p == nameof(Mouvement.Etat))
        {
            e.CellStyle.ForeColor = Convert.ToString(e.Value) == "Pointé" ? Theme.Emeraude700 : Theme.OrFonce;
            e.CellStyle.Font = _gras;
        }
    }
}
