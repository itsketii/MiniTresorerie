using MiniTresorerie.DataAccess;
using MiniTresorerie.Models;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Fenêtre de détail d'une catégorie de recette ou de dépense.</summary>
public partial class FrmCategorieDetail : Form
{
    readonly Categorie _c;
    readonly ModeAppel _mode;

    public FrmCategorieDetail(Categorie? c, ModeAppel mode)
    {
        InitializeComponent();
        Icon = Logo.Icone();
        _mode = mode;
        _c = c ?? new Categorie();
        Aide.Preparer(mode, "catégorie", lblTitre, btnEnregistrer, btnFermer, pnlCorps);
        cbType.SelectedIndex = 1;
        if (mode != ModeAppel.AJOUT)
        {
            txtLibelle.Text = _c.CatLibelle;
            cbType.SelectedIndex = _c.CatType == TypesMouvement.Recette ? 0 : 1;
        }
    }

    void btnEnregistrer_Click(object? sender, EventArgs e)
    {
        try
        {
            if (_mode == ModeAppel.SUPPRESSION)
            {
                if (!Aide.ConfirmerSuppression($"la catégorie « {_c.CatLibelle} »")) return;
                CategorieDAO.Delete(_c.CategorieId);
            }
            else
            {
                if (!Aide.Requis(txtLibelle, "Libellé") || !Aide.Requis(cbType, "Type de mouvement")) return;
                _c.CatLibelle = txtLibelle.Text.Trim();
                _c.CatType = cbType.SelectedIndex == 0 ? TypesMouvement.Recette : TypesMouvement.Depense;
                if (_mode == ModeAppel.AJOUT) _c.CategorieId = CategorieDAO.Create(_c);
                else CategorieDAO.Update(_c);
            }
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Opération impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
