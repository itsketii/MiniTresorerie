namespace MiniTresorerie.Models;

public class CompteTresorerie
{
    public int CompteId { get; set; }
    public string CptCode { get; set; } = string.Empty;
    public string CptLibelle { get; set; } = string.Empty;
    public int TypeCompteId { get; set; }
    public string TcLibelle { get; set; } = string.Empty;
    public string CptDevise { get; set; } = "FCFA";
    public decimal CptSoldeInitial { get; set; }
    public DateTime CptDateOuverture { get; set; } = DateTime.Today;
    public bool CptActif { get; set; } = true;
    public string? CptDescription { get; set; }
    public decimal CptSolde { get; set; }
    public string Statut => CptActif ? "Actif" : "Clôturé";
    public override string ToString() => $"{CptCode} – {CptLibelle}";
}

public class Mouvement
{
    public int MouvementId { get; set; }
    public string MvtReference { get; set; } = string.Empty;
    public DateTime MvtDate { get; set; } = DateTime.Today;
    public string MvtType { get; set; } = TypesMouvement.Recette;
    public string MvtLibelle { get; set; } = string.Empty;
    public decimal MvtMontant { get; set; }
    public int CompteId { get; set; }
    public string CptCode { get; set; } = string.Empty;
    public string CptLibelle { get; set; } = string.Empty;
    public int CategorieId { get; set; }
    public string CatLibelle { get; set; } = string.Empty;
    public int? CentreId { get; set; }
    public string CtrCode { get; set; } = string.Empty;
    public string CtrLibelle { get; set; } = string.Empty;
    public int ModePaiementId { get; set; }
    public string MpLibelle { get; set; } = string.Empty;
    public string? MvtTiers { get; set; }
    public string? MvtPiece { get; set; }
    public bool MvtRapproche { get; set; }
    public DateTime? MvtDateRapprochement { get; set; }
    public int UtilisateurId { get; set; }
    public string UsrLogin { get; set; } = string.Empty;
    public DateTime MvtDateSaisie { get; set; }

    public bool EstRecette => MvtType == TypesMouvement.Recette;
    public decimal MontantSigne => EstRecette ? MvtMontant : -MvtMontant;
    public decimal? Entree => EstRecette ? MvtMontant : null;
    public decimal? Sortie => EstRecette ? null : MvtMontant;
    public string Etat => MvtRapproche ? "Pointé" : "À pointer";
    public string Compte => $"{CptCode} – {CptLibelle}";
    public string Centre => string.IsNullOrEmpty(CtrLibelle) ? "—" : CtrLibelle;
}

public class MouvementFiltre
{
    public string? Texte { get; set; }
    public DateTime? DateDebut { get; set; }
    public DateTime? DateFin { get; set; }
    public int? CompteId { get; set; }
    public int? CentreId { get; set; }
    public string? Type { get; set; }
    public bool? Rapproche { get; set; }
}

// ----- Objets de statistiques -----
public class KpiTresorerie
{
    public decimal TresorerieTotale { get; set; }
    public decimal TotalRecettes { get; set; }
    public decimal TotalDepenses { get; set; }
    public int NbMouvements { get; set; }
    public int NbNonRapproches { get; set; }
    public int NbComptes { get; set; }
    public decimal Resultat => TotalRecettes - TotalDepenses;
}

public class PointMensuel
{
    public int Mois { get; set; }
    public decimal Recettes { get; set; }
    public decimal Depenses { get; set; }
}

public class PartCategorie
{
    public string Libelle { get; set; } = string.Empty;
    public string TypeCat { get; set; } = string.Empty;
    public int Nb { get; set; }
    public decimal Total { get; set; }
    public string TypeAffiche => TypeCat == TypesMouvement.Recette ? "Recette" : "Dépense";
}

public class LigneCentre
{
    public string Code { get; set; } = string.Empty;
    public string Libelle { get; set; } = string.Empty;
    public decimal Recettes { get; set; }
    public decimal Depenses { get; set; }
    public decimal Solde => Recettes - Depenses;
}
