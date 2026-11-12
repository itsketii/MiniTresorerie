using MiniTresorerie.DataAccess;
using MiniTresorerie.Models;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Rapprochement : pointage des mouvements d'un compte et comparaison avec le solde du relevé.</summary>
public partial class FrmRapprochement : Form
{
    static readonly Font _gras = new Font("Segoe UI", 10F, FontStyle.Bold);
    List<Mouvement> _liste = new();
    CompteTresorerie? _compte;

    public FrmRapprochement()
    {
        InitializeComponent();
        Aide.AlignerEntetes(dgv);
        nudReleve.Minimum = -9_999_999_999_999m;
        nudReleve.Maximum = 9_999_999_999_999m;
    }

    void FrmRapprochement_Load(object? sender, EventArgs e)
    {
        btnPointer.Visible = btnDepointer.Visible = Session.PeutEcrire;
        try
        {
            foreach (var c in CompteTresorerieDAO.ReadAll("", true)) cbCompte.Items.Add(c);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Rapprochement", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        if (cbCompte.Items.Count > 0) cbCompte.SelectedIndex = 0;
        else Calculer();
    }

    void cbCompte_SelectedIndexChanged(object? sender, EventArgs e) => Charger();
    void nudReleve_ValueChanged(object? sender, EventArgs e) => Calculer();
    void btnActualiser_Click(object? sender, EventArgs e) => Charger();
    void btnPointer_Click(object? sender, EventArgs e) => Pointer(true);
    void btnDepointer_Click(object? sender, EventArgs e) => Pointer(false);

    void Charger()
    {
        if (cbCompte.SelectedItem is not CompteTresorerie c) return;
        try
        {
            _compte = CompteTresorerieDAO.ReadById(c.CompteId);
            _liste = MouvementDAO.ReadAll(new MouvementFiltre { CompteId = c.CompteId });
            dgv.DataSource = null;
            dgv.DataSource = _liste;
            Calculer();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Rapprochement", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    void Calculer()
    {
        if (_compte == null) { lblKEcartValeur.Text = "—"; return; }
        decimal pointe = _compte.CptSoldeInitial + _liste.Where(m => m.MvtRapproche).Sum(m => m.MontantSigne);
        decimal ecart = nudReleve.Value - pointe;
        lblKComptaValeur.Text = Fmt.Fcfa(_compte.CptSolde);
        lblKComptaDetail.Text = "Tous mouvements confondus";
        lblKPointeValeur.Text = Fmt.Fcfa(pointe);
        lblKPointeDetail.Text = "Mouvements déjà pointés";
        lblKReleveValeur.Text = Fmt.Fcfa(nudReleve.Value);
        lblKReleveDetail.Text = "Saisi dans le champ ci-dessus";
        lblKEcartValeur.Text = Fmt.Fcfa(ecart);
        lblKEcartValeur.ForeColor = ecart == 0 ? Theme.Emeraude700 : Theme.Rouge;
        lblKEcartDetail.Text = ecart == 0 ? "Rapprochement équilibré" : "Écart à justifier";
        pnlKEcartAccent.BackColor = ecart == 0 ? Theme.Emeraude600 : Theme.Rouge;
        foreach (var l in new[] { lblKComptaValeur, lblKPointeValeur, lblKReleveValeur, lblKEcartValeur }) Aide.AjusterPolice(l, 18f);
    }

    void Pointer(bool etat)
    {
        var sel = dgv.SelectedRows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem as Mouvement).Where(m => m != null).Select(m => m!).ToList();
        if (sel.Count == 0)
        {
            MessageBox.Show("Sélectionnez au moins une ligne.", "Rapprochement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        try
        {
            foreach (var m in sel) MouvementDAO.Rapprocher(m.MouvementId, etat);
            Charger();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Rapprochement", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
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
