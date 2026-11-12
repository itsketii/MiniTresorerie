using System.Globalization;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Fenêtre principale : barre latérale de navigation, en-tête et zone de contenu où s'affichent les pages.</summary>
public partial class FrmPrincipal : Form
{
    public bool Deconnexion { get; private set; }

    // pour chaque bouton de navigation : titre, sous-titre et fabrique de la page à afficher
    readonly Dictionary<Button, (string Titre, string Sous, Func<Form> Page)> _pages = new();
    Form? _pageActive;

    public FrmPrincipal()
    {
        InitializeComponent();
        Icon = Logo.Icone();
        DoubleBuffered = true;

        var u = Session.Utilisateur;
        lblUserNom.Text = u?.NomComplet ?? "";
        lblUserRole.Text = u?.RoleLibelle ?? "";
        lblInitiales.Text = u?.Initiales ?? "?";
        string date = DateTime.Today.ToString("dddd d MMMM yyyy", new CultureInfo("fr-FR"));
        lblDate.Text = char.ToUpper(date[0]) + date[1..];

        _pages[btnNavTableau] = ("Tableau de bord", "Vue d'ensemble de votre trésorerie", () => new FrmTableauDeBord());
        _pages[btnNavComptes] = ("Comptes", "Comptes de caisse, banque et mobile money", () => new FrmCompteListe());
        _pages[btnNavMouvements] = ("Mouvements", "Journal des recettes et des dépenses", () => new FrmMouvementListe());
        _pages[btnNavRapprochement] = ("Rapprochement", "Pointage des mouvements et rapprochement bancaire", () => new FrmRapprochement());
        _pages[btnNavRapports] = ("Rapports et états", "États de synthèse, impression et exports PDF / Excel", () => new FrmRapports());
        _pages[btnNavCategories] = ("Catégories", "Catégories de recettes et de dépenses", () => new FrmCategorieListe());
        _pages[btnNavCentres] = ("Centres d'imputation", "Centres d'imputation analytique", () => new FrmCentreListe());
        _pages[btnNavModes] = ("Modes de paiement", "Espèces, chèque, virement, mobile money…", () => new FrmModePaiementListe());
        _pages[btnNavTypes] = ("Types de compte", "Types de comptes de trésorerie", () => new FrmTypeCompteListe());
        _pages[btnNavUtilisateurs] = ("Utilisateurs", "Comptes utilisateurs et rôles (Admin / Comptable / Lecteur)", () => new FrmUtilisateurListe());

        btnNavUtilisateurs.Visible = Session.EstAdmin;
        FormClosing += FrmPrincipal_FormClosing;
    }

    void FrmPrincipal_Load(object? sender, EventArgs e) => Ouvrir(btnNavTableau);

    void Nav_Click(object? sender, EventArgs e) => Ouvrir((Button)sender!);

    /// <summary>Affiche la page associée au bouton dans la zone de contenu (formulaire intégré).</summary>
    void Ouvrir(Button b)
    {
        var (titre, sous, fabrique) = _pages[b];
        Form page;
        try
        {
            page = fabrique();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Impossible d'ouvrir cette page : " + ex.Message, "Mini Trésorerie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        foreach (var x in _pages.Keys) Activer(x, x == b);
        lblTitre.Text = titre;
        lblSousTitre.Text = sous;

        page.TopLevel = false;
        page.FormBorderStyle = FormBorderStyle.None;
        page.Dock = DockStyle.Fill;
        var ancienne = _pageActive;
        _pageActive = page;
        pnlContenu.Controls.Add(page);
        page.Show();
        if (ancienne != null)
        {
            pnlContenu.Controls.Remove(ancienne);
            ancienne.Dispose();
        }
    }

    static void Activer(Button b, bool actif)
    {
        b.BackColor = actif ? Theme.Emeraude700 : Color.Transparent;
        b.ForeColor = actif ? Color.White : Theme.Emeraude100;
        b.Font = new Font("Segoe UI", 10.5F, actif ? FontStyle.Bold : FontStyle.Regular);
    }

    void btnMotDePasse_Click(object? sender, EventArgs e)
    {
        using var f = new FrmMotDePasse();
        f.ShowDialog(this);
    }

    void btnDeconnexion_Click(object? sender, EventArgs e)
    {
        if (MessageBox.Show("Voulez-vous vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        Deconnexion = true;
        Close();
    }

    void FrmPrincipal_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (Deconnexion || e.CloseReason != CloseReason.UserClosing) return;
        if (MessageBox.Show("Voulez-vous vraiment quitter Mini Trésorerie ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            e.Cancel = true;
    }
}
