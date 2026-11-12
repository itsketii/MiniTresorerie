namespace MiniTresorerie.Models;

public class TypeCompte
{
    public int TypeCompteId { get; set; }
    public string TcLibelle { get; set; } = string.Empty;
    public override string ToString() => TcLibelle;
}

public class ModePaiement
{
    public int ModePaiementId { get; set; }
    public string MpLibelle { get; set; } = string.Empty;
    public override string ToString() => MpLibelle;
}

public static class TypesMouvement
{
    public const string Recette = "RECETTE";
    public const string Depense = "DEPENSE";
}

public class Categorie
{
    public int CategorieId { get; set; }
    public string CatLibelle { get; set; } = string.Empty;
    public string CatType { get; set; } = TypesMouvement.Depense;
    public string TypeAffiche => CatType == TypesMouvement.Recette ? "Recette" : "Dépense";
    public override string ToString() => CatLibelle;
}

/// <summary>Centre d'imputation analytique (service, projet, département...)</summary>
public class CentreImputation
{
    public int CentreId { get; set; }
    public string CtrCode { get; set; } = string.Empty;
    public string CtrLibelle { get; set; } = string.Empty;
    public string? CtrResponsable { get; set; }
    public string? CtrDescription { get; set; }
    public bool CtrActif { get; set; } = true;
    public string Statut => CtrActif ? "Actif" : "Inactif";
    public override string ToString() => $"{CtrCode} – {CtrLibelle}";
}
