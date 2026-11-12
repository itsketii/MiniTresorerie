using MiniTresorerie.DataAccess;
using MiniTresorerie.Models;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Fenêtre de détail d'un type de compte (ajout, modification, consultation, suppression).</summary>
public partial class FrmTypeCompteDetail : Form
{
    readonly TypeCompte _t;
    readonly ModeAppel _mode;

    public FrmTypeCompteDetail(TypeCompte? t, ModeAppel mode)
    {
        InitializeComponent();
        Icon = Logo.Icone();
        _mode = mode;
        _t = t ?? new TypeCompte();
        Aide.Preparer(mode, "type de compte", lblTitre, btnEnregistrer, btnFermer, pnlCorps);
        if (mode != ModeAppel.AJOUT) txtLibelle.Text = _t.TcLibelle;
    }

    void btnEnregistrer_Click(object? sender, EventArgs e)
    {
        try
        {
            if (_mode == ModeAppel.SUPPRESSION)
            {
                if (!Aide.ConfirmerSuppression($"le type « {_t.TcLibelle} »")) return;
                TypeCompteDAO.Delete(_t.TypeCompteId);
            }
            else
            {
                if (!Aide.Requis(txtLibelle, "Libellé")) return;
                _t.TcLibelle = txtLibelle.Text.Trim();
                if (_mode == ModeAppel.AJOUT) _t.TypeCompteId = TypeCompteDAO.Create(_t);
                else TypeCompteDAO.Update(_t);
            }
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Opération impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
