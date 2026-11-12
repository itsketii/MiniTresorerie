using MiniTresorerie.DataAccess;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Écran d'authentification : illustration à gauche, formulaire à droite.</summary>
public partial class FrmConnexion : Form
{
    int _essais;

    public FrmConnexion()
    {
        InitializeComponent();
        Icon = Logo.Icone();
        DoubleBuffered = true;
        Deplacement.Activer(pnlIllustration);
        Deplacement.Activer(this);
    }

    void FrmConnexion_Load(object? sender, EventArgs e) => txtLogin.Focus();

    void btnFermer_Click(object? sender, EventArgs e) => DialogResult = DialogResult.Cancel;

    void chkAfficher_CheckedChanged(object? sender, EventArgs e) => txtMdp.UseSystemPasswordChar = !chkAfficher.Checked;

    void btnConnexion_Click(object? sender, EventArgs e)
    {
        lblErreur.Text = "";
        if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrEmpty(txtMdp.Text))
        {
            lblErreur.Text = "Saisissez votre identifiant et votre mot de passe.";
            return;
        }
        try
        {
            Cursor = Cursors.WaitCursor;
            var u = UtilisateurDAO.Authentifier(txtLogin.Text.Trim(), txtMdp.Text);
            if (u == null)
            {
                _essais++;
                lblErreur.Text = _essais >= 3
                    ? "Identifiants incorrects (ou compte désactivé). Contactez l'administrateur."
                    : "Identifiant ou mot de passe incorrect.";
                txtMdp.Clear();
                txtMdp.Focus();
                return;
            }
            Session.Utilisateur = u;
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            lblErreur.Text = "Erreur : " + ErreurBD.Message(ex);
        }
        finally
        {
            Cursor = Cursors.Default;
        }
    }
}
