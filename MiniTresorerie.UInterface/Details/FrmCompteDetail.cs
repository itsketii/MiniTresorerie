using MiniTresorerie.DataAccess;
using MiniTresorerie.Models;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Fenêtre de détail d'un compte de trésorerie (caisse, banque, mobile money…).</summary>
public partial class FrmCompteDetail : Form
{
    readonly CompteTresorerie _c;
    readonly ModeAppel _mode;

    public FrmCompteDetail(CompteTresorerie? c, ModeAppel mode)
    {
        InitializeComponent();
        Icon = Logo.Icone();
        _mode = mode;
        _c = c ?? new CompteTresorerie();
        nudSolde.Maximum = 9_999_999_999_999m;
        try
        {
            foreach (var t in TypeCompteDAO.ReadAll("")) cbType.Items.Add(t);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Erreur de chargement", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        Aide.Preparer(mode, "compte de trésorerie", lblTitre, btnEnregistrer, btnFermer, pnlCorps);
        if (mode != ModeAppel.AJOUT)
        {
            txtCode.Text = _c.CptCode;
            txtLibelle.Text = _c.CptLibelle;
            Aide.Choisir<TypeCompte>(cbType, t => t.TypeCompteId == _c.TypeCompteId);
            txtDevise.Text = _c.CptDevise;
            nudSolde.Value = Math.Min(nudSolde.Maximum, Math.Max(0, _c.CptSoldeInitial));
            dtOuverture.Value = _c.CptDateOuverture < dtOuverture.MinDate ? dtOuverture.MinDate : _c.CptDateOuverture;
            chkActif.Checked = _c.CptActif;
            txtDesc.Text = _c.CptDescription;
        }
    }

    void btnEnregistrer_Click(object? sender, EventArgs e)
    {
        try
        {
            if (_mode == ModeAppel.SUPPRESSION)
            {
                if (!Aide.ConfirmerSuppression($"le compte « {_c.CptLibelle} »")) return;
                CompteTresorerieDAO.Delete(_c.CompteId);
            }
            else
            {
                if (!Aide.Requis(txtCode, "Code") || !Aide.Requis(txtLibelle, "Libellé du compte")
                    || !Aide.Requis(cbType, "Type de compte") || !Aide.Requis(txtDevise, "Devise")) return;
                _c.CptCode = txtCode.Text.Trim().ToUpperInvariant();
                _c.CptLibelle = txtLibelle.Text.Trim();
                _c.TypeCompteId = ((TypeCompte)cbType.SelectedItem!).TypeCompteId;
                _c.CptDevise = txtDevise.Text.Trim().ToUpperInvariant();
                _c.CptSoldeInitial = nudSolde.Value;
                _c.CptDateOuverture = dtOuverture.Value.Date;
                _c.CptActif = chkActif.Checked;
                _c.CptDescription = txtDesc.Text.Trim();
                if (_mode == ModeAppel.AJOUT) _c.CompteId = CompteTresorerieDAO.Create(_c);
                else CompteTresorerieDAO.Update(_c);
            }
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Opération impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
