using MiniTresorerie.DataAccess;
using MiniTresorerie.Models;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>États de synthèse : journal, situation des comptes, synthèses par catégorie et par centre — imprimables et exportables.</summary>
public partial class FrmRapports : Form
{
    string _periode = string.Empty;

    public FrmRapports()
    {
        InitializeComponent();
        foreach (var g in new[] { dgvJournal, dgvComptes, dgvCategories, dgvCentres }) Aide.AlignerEntetes(g);
    }

    void FrmRapports_Load(object? sender, EventArgs e)
    {
        cbRapport.SelectedIndex = 0;
        dtDebut.Value = new DateTime(DateTime.Today.Year, 1, 1);
        dtFin.Value = DateTime.Today;
        cbCompte.Items.Add("Tous les comptes");
        try
        {
            foreach (var c in CompteTresorerieDAO.ReadAll("")) cbCompte.Items.Add(c);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Rapports", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        cbCompte.SelectedIndex = 0;
        Generer();
    }

    /// <summary>Grille actuellement affichée selon l'état choisi.</summary>
    DataGridView GrilleActive => cbRapport.SelectedIndex switch
    {
        0 => dgvJournal,
        1 => dgvComptes,
        2 => dgvCategories,
        _ => dgvCentres
    };

    string SousTitre() => $"{_periode}   ·   Édité le {DateTime.Now:dd/MM/yyyy HH:mm} par {Session.Utilisateur?.NomComplet}";

    void cbRapport_SelectedIndexChanged(object? sender, EventArgs e)
    {
        cbCompte.Enabled = cbRapport.SelectedIndex == 0;
        dgvJournal.Visible = cbRapport.SelectedIndex == 0;
        dgvComptes.Visible = cbRapport.SelectedIndex == 1;
        dgvCategories.Visible = cbRapport.SelectedIndex == 2;
        dgvCentres.Visible = cbRapport.SelectedIndex == 3;
    }

    void btnGenerer_Click(object? sender, EventArgs e) => Generer();
    void btnImprimer_Click(object? sender, EventArgs e) => ImpressionGrille.Apercu(GrilleActive, cbRapport.Text, SousTitre());
    void btnPdf_Click(object? sender, EventArgs e) => ImpressionGrille.Pdf(GrilleActive, cbRapport.Text, SousTitre());
    void btnExcel_Click(object? sender, EventArgs e) => Exporteur.Csv(GrilleActive, cbRapport.Text);

    void Generer()
    {
        DateTime d1 = dtDebut.Value.Date, d2 = dtFin.Value.Date;
        if (d2 < d1)
        {
            MessageBox.Show("La date de fin doit être postérieure à la date de début.", "Rapports", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        _periode = $"Période du {d1:dd/MM/yyyy} au {d2:dd/MM/yyyy}";
        try
        {
            switch (cbRapport.SelectedIndex)
            {
                case 0:
                {
                    var l = MouvementDAO.ReadAll(new MouvementFiltre
                    {
                        DateDebut = d1, DateFin = d2, CompteId = (cbCompte.SelectedItem as CompteTresorerie)?.CompteId
                    }).OrderBy(x => x.MvtDate).ThenBy(x => x.MouvementId).ToList();
                    dgvJournal.DataSource = null;
                    dgvJournal.DataSource = l;
                    decimal ent = l.Sum(x => x.Entree ?? 0m), sor = l.Sum(x => x.Sortie ?? 0m);
                    lblResume.Text = $"{l.Count} mouvement(s)   ·   Entrées : {Fmt.Fcfa(ent)}   ·   Sorties : {Fmt.Fcfa(sor)}   ·   Solde de la période : {Fmt.Fcfa(ent - sor)}";
                    break;
                }
                case 1:
                {
                    var l = CompteTresorerieDAO.ReadAll("");
                    dgvComptes.DataSource = null;
                    dgvComptes.DataSource = l;
                    _periode = $"Situation au {DateTime.Today:dd/MM/yyyy}";
                    lblResume.Text = $"{l.Count} compte(s)   ·   Trésorerie totale (comptes actifs) : {Fmt.Fcfa(l.Where(c => c.CptActif).Sum(c => c.CptSolde))}";
                    break;
                }
                case 2:
                {
                    var l = StatistiquesDAO.ParCategorie(null, d1, d2);
                    dgvCategories.DataSource = null;
                    dgvCategories.DataSource = l;
                    decimal r = l.Where(x => x.TypeCat == TypesMouvement.Recette).Sum(x => x.Total);
                    decimal d = l.Where(x => x.TypeCat == TypesMouvement.Depense).Sum(x => x.Total);
                    lblResume.Text = $"Recettes : {Fmt.Fcfa(r)}   ·   Dépenses : {Fmt.Fcfa(d)}   ·   Résultat : {Fmt.Fcfa(r - d)}";
                    break;
                }
                default:
                {
                    var l = StatistiquesDAO.ParCentre(d1, d2);
                    dgvCentres.DataSource = null;
                    dgvCentres.DataSource = l;
                    lblResume.Text = $"{l.Count} centre(s)   ·   Recettes : {Fmt.Fcfa(l.Sum(x => x.Recettes))}   ·   Dépenses : {Fmt.Fcfa(l.Sum(x => x.Depenses))}";
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Rapports", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
