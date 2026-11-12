using MySql.Data.MySqlClient;

namespace MiniTresorerie.DataAccess;

/// <summary>
/// Chaîne de connexion MySQL. Peut être surchargée par un fichier "connexion.config"
/// placé à côté de l'exécutable (première ligne non vide, non commentée).
/// </summary>
public static class Connexion
{
    public static string Chaine { get; set; } =
        "Server=localhost;Port=3306;Database=dbMiniTresorerie;User ID=root;Password=;" +
        "CharSet=utf8mb4;AllowPublicKeyRetrieval=True;Connection Timeout=8;";

    static Connexion()
    {
        try
        {
            string f = Path.Combine(AppContext.BaseDirectory, "connexion.config");
            if (!File.Exists(f)) return;
            string? l = File.ReadAllLines(f).FirstOrDefault(x => !string.IsNullOrWhiteSpace(x) && !x.TrimStart().StartsWith('#'));
            if (l != null) Chaine = l.Trim();
        }
        catch { /* on garde la chaîne par défaut */ }
    }

    public static bool Tester(out string erreur)
    {
        try
        {
            using var cn = new MySqlConnection(Chaine);
            cn.Open();
            erreur = string.Empty;
            return true;
        }
        catch (Exception ex)
        {
            erreur = ex.Message;
            return false;
        }
    }
}
