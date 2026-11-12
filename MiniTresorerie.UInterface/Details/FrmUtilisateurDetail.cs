using MiniTresorerie.DataAccess;
using MiniTresorerie.Models;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Fenêtre de détail d'un utilisateur (administration des comptes et des rôles).</summary>
public partial class FrmUtilisateurDetail : Form
{
    readonly Utilisateur _u;
    readonly ModeAppel _mode;

    public FrmUtilisateurDetail(Utilisateur? u, ModeAppel mode)
    {
        InitializeComponent();
        Icon = Logo.Icone();
        _mode = mode;
        _u = u ?? new Utilisateur();
        try
        {
            foreach (var r in RoleDAO.ReadAll()) cbRole.Items.Add(r);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Erreur de chargement", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        lblMdp.Text = mode == ModeAppel.AJOUT ? "Mot de passe *" : "Nouveau mot de passe (facultatif)";
        Aide.Preparer(mode, "utilisateur", lblTitre, btnEnregistrer, btnFermer, pnlCorps);
        if (mode != ModeAppel.AJOUT)
        {
            txtNom.Text = _u.UsrNom;
            txtPrenom.Text = _u.UsrPrenom;
            txtLogin.Text = _u.UsrLogin;
            Aide.Choisir<Role>(cbRole, r => r.RoleId == _u.RoleId);
            chkActif.Checked = _u.UsrActif;
        }
    }

    void btnEnregistrer_Click(object? sender, EventArgs e)
    {
        try
        {
            if (_mode == ModeAppel.SUPPRESSION)
            {
                if (Session.Utilisateur != null && _u.UtilisateurId == Session.Utilisateur.UtilisateurId)
                {
                    MessageBox.Show("Vous ne pouvez pas supprimer votre propre compte.", "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!Aide.ConfirmerSuppression($"l'utilisateur « {_u.UsrLogin} »")) return;
                UtilisateurDAO.Delete(_u.UtilisateurId);
            }
            else
            {
                if (!Aide.Requis(txtNom, "Nom") || !Aide.Requis(txtPrenom, "Prénom")
                    || !Aide.Requis(txtLogin, "Identifiant de connexion") || !Aide.Requis(cbRole, "Rôle")) return;
                string mdp = txtMdp.Text;
                if (mdp.Length > 0 || _mode == ModeAppel.AJOUT)
                {
                    if (mdp.Length < 6)
                    {
                        MessageBox.Show("Le mot de passe doit contenir au moins 6 caractères.", "Contrôle de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMdp.Focus();
                        return;
                    }
                    if (mdp != txtMdp2.Text)
                    {
                        MessageBox.Show("La confirmation du mot de passe ne correspond pas.", "Contrôle de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMdp2.Focus();
                        return;
                    }
                }
                _u.UsrNom = txtNom.Text.Trim();
                _u.UsrPrenom = txtPrenom.Text.Trim();
                _u.UsrLogin = txtLogin.Text.Trim();
                _u.RoleId = ((Role)cbRole.SelectedItem!).RoleId;
                _u.UsrActif = chkActif.Checked;
                if (_mode == ModeAppel.AJOUT) _u.UtilisateurId = UtilisateurDAO.Create(_u, mdp);
                else UtilisateurDAO.Update(_u, mdp);
            }
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Opération impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
