using MiniTresorerie.DataAccess;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Écran de démarrage animé : vérifie la connexion MySQL puis ouvre l'écran de connexion.</summary>
public partial class FrmDemarrage : Form
{
    float _progres;
    bool _testFait;

    public FrmDemarrage()
    {
        InitializeComponent();
        Icon = Logo.Icone();
        DoubleBuffered = true;
        Deplacement.Activer(pnlFond);
    }

    void FrmDemarrage_Load(object? sender, EventArgs e) => timer1.Start();

    void timer1_Tick(object? sender, EventArgs e)
    {
        _progres += 1.3f;
        if (_progres >= 30 && !_testFait)
        {
            _testFait = true;
            lblEtat.Text = "Connexion à la base MySQL…";
            if (!Connexion.Tester(out string err))
            {
                timer1.Stop();
                MessageBox.Show("Impossible de joindre la base de données.\n\n" + err +
                    "\n\nVérifiez que MySQL est démarré, que les scripts du dossier Database ont été exécutés (01 à 05)\net que la chaîne de connexion du fichier connexion.config est correcte.",
                    "Mini Trésorerie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
                return;
            }
        }
        if (_progres > 60) lblEtat.Text = "Chargement de l'interface…";
        barre.Valeur = _progres;
        if (_progres >= 100)
        {
            timer1.Stop();
            DialogResult = DialogResult.OK;
        }
    }
}
