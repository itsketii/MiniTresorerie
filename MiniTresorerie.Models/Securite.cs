namespace MiniTresorerie.Models;

public static class Roles
{
    public const string Admin = "Admin";
    public const string Comptable = "Comptable";
    public const string Lecteur = "Lecteur";
}

public class Role
{
    public int RoleId { get; set; }
    public string RoleLibelle { get; set; } = string.Empty;
    public string? RoleDescription { get; set; }
    public override string ToString() => RoleLibelle;
}

public class Utilisateur
{
    public int UtilisateurId { get; set; }
    public string UsrNom { get; set; } = string.Empty;
    public string UsrPrenom { get; set; } = string.Empty;
    public string UsrLogin { get; set; } = string.Empty;
    public int RoleId { get; set; }
    public string RoleLibelle { get; set; } = string.Empty;
    public bool UsrActif { get; set; } = true;
    public DateTime? UsrDateCreation { get; set; }
    public DateTime? UsrDerniereConnexion { get; set; }

    public string NomComplet => $"{UsrPrenom} {UsrNom}".Trim();
    public string Statut => UsrActif ? "Actif" : "Désactivé";
    public string Initiales => (string.Concat(UsrPrenom.Take(1)) + string.Concat(UsrNom.Take(1))).ToUpperInvariant();
    public override string ToString() => NomComplet;
}
