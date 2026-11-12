using MiniTresorerie.DataAccess;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Changement du mot de passe de l'utilisateur connecté.</summary>
public partial class FrmMotDePasse : Form
{
    public FrmMotDePasse()
    {
        InitializeComponent();
        Icon = Logo.Icone();
        lblTitre.Text = "Changer mon mot de passe";
        btnEnregistrer.Text = "Changer";
        btnFermer.Text = "Annuler";
    }

    void btnEnregistrer_Click(object? sender, EventArgs e)
    {
        try
        {
            if (!Aide.Requis(txtAncien, "Mot de passe actuel") || !Aide.Requis(txtNouveau, "Nouveau mot de passe")
                || !Aide.Requis(txtConfirm, "Confirmation")) return;
            if (txtNouveau.Text.Length < 6)
            {
                MessageBox.Show("Le nouveau mot de passe doit contenir au moins 6 caractères.", "Contrôle de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNouveau.Text != txtConfirm.Text)
            {
                MessageBox.Show("La confirmation ne correspond pas au nouveau mot de passe.", "Contrôle de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Session.Utilisateur == null) return;
            if (!UtilisateurDAO.ChangerMotDePasse(Session.Utilisateur.UtilisateurId, txtAncien.Text, txtNouveau.Text))
            {
                MessageBox.Show("Le mot de passe actuel est incorrect.", "Sécurité", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Votre mot de passe a été modifié.", "Sécurité", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Opération impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
