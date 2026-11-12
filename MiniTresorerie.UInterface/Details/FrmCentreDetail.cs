using MiniTresorerie.DataAccess;
using MiniTresorerie.Models;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Fenêtre de détail d'un centre d'imputation analytique.</summary>
public partial class FrmCentreDetail : Form
{
    readonly CentreImputation _c;
    readonly ModeAppel _mode;

    public FrmCentreDetail(CentreImputation? c, ModeAppel mode)
    {
        InitializeComponent();
        Icon = Logo.Icone();
        _mode = mode;
        _c = c ?? new CentreImputation();
        Aide.Preparer(mode, "centre d'imputation", lblTitre, btnEnregistrer, btnFermer, pnlCorps);
        if (mode != ModeAppel.AJOUT)
        {
            txtCode.Text = _c.CtrCode;
            txtLibelle.Text = _c.CtrLibelle;
            txtResp.Text = _c.CtrResponsable;
            txtDesc.Text = _c.CtrDescription;
            chkActif.Checked = _c.CtrActif;
        }
    }

    void btnEnregistrer_Click(object? sender, EventArgs e)
    {
        try
        {
            if (_mode == ModeAppel.SUPPRESSION)
            {
                if (!Aide.ConfirmerSuppression($"le centre « {_c.CtrLibelle} »")) return;
                CentreImputationDAO.Delete(_c.CentreId);
            }
            else
            {
                if (!Aide.Requis(txtCode, "Code") || !Aide.Requis(txtLibelle, "Libellé")) return;
                _c.CtrCode = txtCode.Text.Trim().ToUpperInvariant();
                _c.CtrLibelle = txtLibelle.Text.Trim();
                _c.CtrResponsable = txtResp.Text.Trim();
                _c.CtrDescription = txtDesc.Text.Trim();
                _c.CtrActif = chkActif.Checked;
                if (_mode == ModeAppel.AJOUT) _c.CentreId = CentreImputationDAO.Create(_c);
                else CentreImputationDAO.Update(_c);
            }
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Opération impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
