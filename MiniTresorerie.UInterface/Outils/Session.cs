using MiniTresorerie.Models;

namespace MiniTresorerie.UInterface;

public enum ModeAppel { AJOUT, MODIFICATION, CONSULTATION, SUPPRESSION }

/// <summary>Utilisateur connecté et droits associés au rôle.</summary>
public static class Session
{
    public static Utilisateur? Utilisateur { get; set; }
    public static bool EstAdmin => Utilisateur?.RoleLibelle == Roles.Admin;
    public static bool PeutEcrire => Utilisateur != null && (Utilisateur.RoleLibelle == Roles.Admin || Utilisateur.RoleLibelle == Roles.Comptable);
}
