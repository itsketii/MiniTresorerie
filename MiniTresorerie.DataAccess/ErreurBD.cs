using MySql.Data.MySqlClient;

namespace MiniTresorerie.DataAccess;

/// <summary>Transforme les exceptions MySQL en messages compréhensibles pour l'utilisateur.</summary>
public static class ErreurBD
{
    public static string Message(Exception ex)
    {
        if (ex is MySqlException m)
        {
            switch (m.Number)
            {
                case 1451:
                case 1217:
                    return "Suppression impossible : cet élément est utilisé ailleurs (comptes, mouvements, …).";
                case 1062:
                    return "Doublon détecté : une valeur unique (code, identifiant, libellé ou référence) existe déjà.";
                case 1452:
                case 1216:
                    return "Référence invalide : l'élément lié n'existe plus.";
                case 1305:
                    return "Procédure stockée introuvable : exécutez les scripts du dossier Database dans l'ordre (01 à 05).";
                case 1049:
                    return "Base de données introuvable : exécutez d'abord 01_schema.sql.";
                case 1045:
                case 2003:
                    return "Connexion MySQL impossible : " + m.Message;
                case 3819:
                case 4025:
                    return "Valeur refusée par une règle de contrôle (ex. montant strictement positif).";
                default:
                    // SIGNAL SQLSTATE '45000' (règles de gestion) : message métier prêt à l'emploi
                    return m.Message;
            }
        }
        return ex.Message;
    }
}
