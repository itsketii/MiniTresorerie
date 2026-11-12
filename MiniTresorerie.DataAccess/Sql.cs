using System.Data;
using MySql.Data.MySqlClient;

namespace MiniTresorerie.DataAccess;

/// <summary>Utilitaires partagés par les classes DAO (paramètres, lecture, valeurs NULL).</summary>
internal static class Sql
{
    public static MySqlCommand Proc(MySqlConnection cn, string nom) =>
        new MySqlCommand(nom, cn) { CommandType = CommandType.StoredProcedure };

    // --- conversions C# -> paramètre (NULL géré) ---
    public static object Txt(string? s) => string.IsNullOrWhiteSpace(s) ? (object)DBNull.Value : s.Trim();
    public static object Nb(int? i) => i.HasValue ? (object)i.Value : DBNull.Value;
    public static object Dt(DateTime? d) => d.HasValue ? (object)d.Value.Date : DBNull.Value;
    public static object Dec(decimal? d) => d.HasValue ? (object)d.Value : DBNull.Value;
    public static object Bool(bool? b) => b.HasValue ? (object)(b.Value ? 1 : 0) : DBNull.Value;

    public static MySqlParameter Sortie(MySqlCommand cmd, string nom)
    {
        var p = new MySqlParameter(nom, MySqlDbType.Int32) { Direction = ParameterDirection.Output };
        cmd.Parameters.Add(p);
        return p;
    }

    public static int Id(MySqlParameter p) =>
        (p.Value == null || p.Value == DBNull.Value) ? 0 : Convert.ToInt32(p.Value);
}

/// <summary>Méthodes de lecture tolérantes aux NULL.</summary>
internal static class ReaderExt
{
    public static string Str(this MySqlDataReader r, string col)
    {
        int i = r.GetOrdinal(col);
        return r.IsDBNull(i) ? string.Empty : Convert.ToString(r.GetValue(i)) ?? string.Empty;
    }

    public static string? StrN(this MySqlDataReader r, string col)
    {
        int i = r.GetOrdinal(col);
        return r.IsDBNull(i) ? null : Convert.ToString(r.GetValue(i));
    }

    public static int Int(this MySqlDataReader r, string col)
    {
        int i = r.GetOrdinal(col);
        return r.IsDBNull(i) ? 0 : Convert.ToInt32(r.GetValue(i));
    }

    public static int? IntN(this MySqlDataReader r, string col)
    {
        int i = r.GetOrdinal(col);
        return r.IsDBNull(i) ? null : Convert.ToInt32(r.GetValue(i));
    }

    public static decimal Dec(this MySqlDataReader r, string col)
    {
        int i = r.GetOrdinal(col);
        return r.IsDBNull(i) ? 0m : Convert.ToDecimal(r.GetValue(i));
    }

    public static bool Bool(this MySqlDataReader r, string col)
    {
        int i = r.GetOrdinal(col);
        return !r.IsDBNull(i) && Convert.ToInt32(r.GetValue(i)) != 0;
    }

    public static DateTime Date(this MySqlDataReader r, string col)
    {
        int i = r.GetOrdinal(col);
        return r.IsDBNull(i) ? DateTime.MinValue : Convert.ToDateTime(r.GetValue(i));
    }

    public static DateTime? DateN(this MySqlDataReader r, string col)
    {
        int i = r.GetOrdinal(col);
        return r.IsDBNull(i) ? null : Convert.ToDateTime(r.GetValue(i));
    }
}
