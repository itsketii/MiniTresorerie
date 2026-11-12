using MiniTresorerie.DataAccess;
using MiniTresorerie.Models;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Fenêtre de détail d'un mode de paiement.</summary>
public partial class FrmModePaiementDetail : Form
{
    readonly ModePaiement _m;
    readonly ModeAppel _mode;

    public FrmModePaiementDetail(ModePaiement? m, ModeAppel mode)
    {
        InitializeComponent();
        Icon = Logo.Icone();
        _mode = mode;
        _m = m ?? new ModePaiement();
        Aide.Preparer(mode, "mode de paiement", lblTitre, btnEnregistrer, btnFermer, pnlCorps);
        if (mode != ModeAppel.AJOUT) txtLibelle.Text = _m.MpLibelle;
    }

    void btnEnregistrer_Click(object? sender, EventArgs e)
    {
        try
        {
            if (_mode == ModeAppel.SUPPRESSION)
            {
                if (!Aide.ConfirmerSuppression($"le mode « {_m.MpLibelle} »")) return;
                ModePaiementDAO.Delete(_m.ModePaiementId);
            }
            else
            {
                if (!Aide.Requis(txtLibelle, "Libellé")) return;
                _m.MpLibelle = txtLibelle.Text.Trim();
                if (_mode == ModeAppel.AJOUT) _m.ModePaiementId = ModePaiementDAO.Create(_m);
                else ModePaiementDAO.Update(_m);
            }
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Opération impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
