using MiniTresorerie.DataAccess;
using MiniTresorerie.Models;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Tableau de bord : indicateurs clés, histogramme mensuel, répartition des dépenses, centres et dernières opérations.</summary>
public partial class FrmTableauDeBord : Form
{
    static readonly Font _gras = new Font("Segoe UI", 10F, FontStyle.Bold);
    bool _init = true;

    public FrmTableauDeBord()
    {
        InitializeComponent();
        Aide.AlignerEntetes(dgvOps);
    }

    void FrmTableauDeBord_Load(object? sender, EventArgs e)
    {
        int an = DateTime.Today.Year;
        for (int a = an; a >= an - 4; a--) cbAnnee.Items.Add(a);
        cbAnnee.SelectedIndex = 0;
        cbMois.SelectedIndex = 0;
        _init = false;
        Rafraichir();
    }

    void Filtre_Changed(object? sender, EventArgs e) { if (!_init) Rafraichir(); }

    void btnActualiser_Click(object? sender, EventArgs e) => Rafraichir();

    void Rafraichir()
    {
        if (cbAnnee.SelectedItem == null) return;
        try
        {
            int annee = (int)cbAnnee.SelectedItem;
            int mois = cbMois.SelectedIndex;
            DateTime debut = mois == 0 ? new DateTime(annee, 1, 1) : new DateTime(annee, mois, 1);
            DateTime fin = mois == 0 ? new DateTime(annee, 12, 31) : debut.AddMonths(1).AddDays(-1);
            lblPeriode.Text = mois == 0 ? $"Exercice {annee}" : $"{cbMois.Text} {annee}";

            var k = StatistiquesDAO.Kpi(debut, fin);
            lblKTresoValeur.Text = Fmt.Fcfa(k.TresorerieTotale);
            lblKTresoDetail.Text = $"{k.NbComptes} compte(s) actif(s)";
            lblKRecValeur.Text = Fmt.Fcfa(k.TotalRecettes);
            lblKRecDetail.Text = $"{k.NbMouvements} mouvement(s) sur la période";
            lblKDepValeur.Text = Fmt.Fcfa(k.TotalDepenses);
            lblKDepDetail.Text = k.TotalRecettes > 0 ? $"{k.TotalDepenses / k.TotalRecettes * 100m:0}% des recettes" : "—";
            lblKResValeur.Text = (k.Resultat >= 0 ? "+" : "") + Fmt.Fcfa(k.Resultat);
            lblKResValeur.ForeColor = k.Resultat >= 0 ? Theme.Emeraude700 : Theme.Rouge;
            lblKResDetail.Text = $"{k.NbNonRapproches} mouvement(s) à pointer";
            foreach (var l in new[] { lblKTresoValeur, lblKRecValeur, lblKDepValeur, lblKResValeur }) Aide.AjusterPolice(l, 18f);

            gBarres.Donnees = StatistiquesDAO.Mensuel(annee);
            gDonut.Donnees = StatistiquesDAO.ParCategorie(TypesMouvement.Depense, debut, fin);
            gCentres.Donnees = StatistiquesDAO.ParCentre(debut, fin)
                .Select(c => new ElementBarre { Libelle = c.Libelle, Valeur = c.Depenses }).ToList();

            dgvOps.DataSource = null;
            dgvOps.DataSource = MouvementDAO.ReadAll(new MouvementFiltre { DateDebut = debut, DateFin = fin }).Take(8).ToList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Tableau de bord", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    void dgvOps_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0 || dgvOps.Columns[e.ColumnIndex].DataPropertyName != nameof(Mouvement.MontantSigne)) return;
        e.CellStyle.ForeColor = Convert.ToDecimal(e.Value ?? 0m) < 0 ? Theme.Rouge : Theme.Emeraude700;
        e.CellStyle.Font = _gras;
    }
}
