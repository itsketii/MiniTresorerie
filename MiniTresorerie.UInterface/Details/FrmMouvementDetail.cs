using MiniTresorerie.DataAccess;
using MiniTresorerie.Models;
using MiniTresorerie.UInterface.Composants;

namespace MiniTresorerie.UInterface;

/// <summary>Fenêtre de saisie d'un mouvement de trésorerie (recette ou dépense).</summary>
public partial class FrmMouvementDetail : Form
{
    readonly Mouvement _m;
    readonly ModeAppel _mode;
    readonly List<Categorie> _categories = new();

    public FrmMouvementDetail(Mouvement? m, ModeAppel mode, string typeInitial = TypesMouvement.Recette)
    {
        InitializeComponent();
        Icon = Logo.Icone();
        _mode = mode;
        _m = m ?? new Mouvement { MvtType = typeInitial };
        bool ajout = mode == ModeAppel.AJOUT;
        nudMontant.Maximum = 9_999_999_999_999m;
        try
        {
            _categories = CategorieDAO.ReadAll("");
            foreach (var c in CompteTresorerieDAO.ReadAll("", ajout ? true : (bool?)null)) cbCompte.Items.Add(c);
            cbCentre.Items.Add("— Aucun —");
            foreach (var c in CentreImputationDAO.ReadAll("", ajout ? true : (bool?)null)) cbCentre.Items.Add(c);
            foreach (var mp in ModePaiementDAO.ReadAll("")) cbMode.Items.Add(mp);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Erreur de chargement", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        lblNote.Text = "";
        cbCentre.SelectedIndex = 0;
        Aide.Preparer(mode, "mouvement de trésorerie", lblTitre, btnEnregistrer, btnFermer, pnlCorps);
        cbType.SelectedIndex = _m.EstRecette ? 0 : 1;
        if (!ajout) Remplir();
    }

    void Remplir()
    {
        dtDate.Value = _m.MvtDate < dtDate.MinDate ? DateTime.Today : _m.MvtDate;
        Aide.Choisir<CompteTresorerie>(cbCompte, c => c.CompteId == _m.CompteId);
        nudMontant.Value = Math.Min(nudMontant.Maximum, _m.MvtMontant);
        Aide.Choisir<Categorie>(cbCategorie, c => c.CategorieId == _m.CategorieId);
        if (_m.CentreId.HasValue) Aide.Choisir<CentreImputation>(cbCentre, c => c.CentreId == _m.CentreId.Value);
        else cbCentre.SelectedIndex = 0;
        Aide.Choisir<ModePaiement>(cbMode, c => c.ModePaiementId == _m.ModePaiementId);
        txtTiers.Text = _m.MvtTiers;
        txtPiece.Text = _m.MvtPiece;
        txtRef.Text = _m.MvtReference;
        txtLibelle.Text = _m.MvtLibelle;
    }

    void cbType_SelectedIndexChanged(object? sender, EventArgs e)
    {
        string type = cbType.SelectedIndex == 0 ? TypesMouvement.Recette : TypesMouvement.Depense;
        cbCategorie.Items.Clear();
        foreach (var c in _categories.Where(c => c.CatType == type)) cbCategorie.Items.Add(c);
    }

    void nudMontant_ValueChanged(object? sender, EventArgs e) =>
        lblNote.Text = nudMontant.Value > 0 ? "Arrêté à : " + Nombre.EnLettres((long)nudMontant.Value) + " francs CFA" : "";

    void btnEnregistrer_Click(object? sender, EventArgs e)
    {
        try
        {
            if (_mode == ModeAppel.SUPPRESSION)
            {
                if (!Aide.ConfirmerSuppression($"le mouvement {_m.MvtReference}")) return;
                MouvementDAO.Delete(_m.MouvementId);
                DialogResult = DialogResult.OK;
                return;
            }
            if (!Aide.Requis(cbType, "Type d'opération") || !Aide.Requis(cbCompte, "Compte de trésorerie")
                || !Aide.Requis(nudMontant, "Montant (FCFA)") || !Aide.Requis(cbCategorie, "Catégorie")
                || !Aide.Requis(cbMode, "Mode de paiement") || !Aide.Requis(txtLibelle, "Libellé")) return;

            _m.MvtType = cbType.SelectedIndex == 0 ? TypesMouvement.Recette : TypesMouvement.Depense;
            _m.MvtDate = dtDate.Value.Date;
            _m.MvtMontant = nudMontant.Value;
            _m.CompteId = ((CompteTresorerie)cbCompte.SelectedItem!).CompteId;
            _m.CategorieId = ((Categorie)cbCategorie.SelectedItem!).CategorieId;
            _m.CentreId = (cbCentre.SelectedItem as CentreImputation)?.CentreId;
            _m.ModePaiementId = ((ModePaiement)cbMode.SelectedItem!).ModePaiementId;
            _m.MvtTiers = txtTiers.Text.Trim();
            _m.MvtPiece = txtPiece.Text.Trim();
            _m.MvtLibelle = txtLibelle.Text.Trim();

            if (_mode == ModeAppel.AJOUT)
            {
                _m.UtilisateurId = Session.Utilisateur!.UtilisateurId;
                _m.MouvementId = MouvementDAO.Create(_m);
                var cree = MouvementDAO.ReadById(_m.MouvementId);
                var rep = MessageBox.Show($"Opération enregistrée (réf. {cree?.MvtReference}).\n\nImprimer le reçu maintenant ?",
                    "Mouvement enregistré", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rep == DialogResult.Yes && cree != null) ImpressionRecu.Apercu(cree);
            }
            else
            {
                MouvementDAO.Update(_m);
            }
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ErreurBD.Message(ex), "Opération impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
