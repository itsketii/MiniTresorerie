using MiniTresorerie.Models;
using MySql.Data.MySqlClient;

namespace MiniTresorerie.DataAccess;

public static class RoleDAO
{
    public static List<Role> ReadAll()
    {
        var l = new List<Role>();
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Role_ReadAll");
        cn.Open();
        using var r = cmd.ExecuteReader();
        while (r.Read())
            l.Add(new Role { RoleId = r.Int("roleId"), RoleLibelle = r.Str("roleLibelle"), RoleDescription = r.StrN("roleDescription") });
        return l;
    }
}

public static class TypeCompteDAO
{
    public static int Create(TypeCompte t)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_TypeCompte_Create");
        cmd.Parameters.AddWithValue("@p_libelle", Sql.Txt(t.TcLibelle));
        var pId = Sql.Sortie(cmd, "@p_id");
        cn.Open();
        cmd.ExecuteNonQuery();
        return Sql.Id(pId);
    }

    public static List<TypeCompte> ReadAll(string? filtre)
    {
        var l = new List<TypeCompte>();
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_TypeCompte_ReadAll");
        cmd.Parameters.AddWithValue("@p_filtre", Sql.Txt(filtre));
        cn.Open();
        using var r = cmd.ExecuteReader();
        while (r.Read()) l.Add(new TypeCompte { TypeCompteId = r.Int("typeCompteId"), TcLibelle = r.Str("tcLibelle") });
        return l;
    }

    public static TypeCompte? ReadById(int id)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_TypeCompte_ReadById");
        cmd.Parameters.AddWithValue("@p_id", id);
        cn.Open();
        using var r = cmd.ExecuteReader();
        return r.Read() ? new TypeCompte { TypeCompteId = r.Int("typeCompteId"), TcLibelle = r.Str("tcLibelle") } : null;
    }

    public static void Update(TypeCompte t)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_TypeCompte_Update");
        cmd.Parameters.AddWithValue("@p_id", t.TypeCompteId);
        cmd.Parameters.AddWithValue("@p_libelle", Sql.Txt(t.TcLibelle));
        cn.Open();
        cmd.ExecuteNonQuery();
    }

    public static void Delete(int id)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_TypeCompte_Delete");
        cmd.Parameters.AddWithValue("@p_id", id);
        cn.Open();
        cmd.ExecuteNonQuery();
    }
}

public static class ModePaiementDAO
{
    public static int Create(ModePaiement m)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_ModePaiement_Create");
        cmd.Parameters.AddWithValue("@p_libelle", Sql.Txt(m.MpLibelle));
        var pId = Sql.Sortie(cmd, "@p_id");
        cn.Open();
        cmd.ExecuteNonQuery();
        return Sql.Id(pId);
    }

    public static List<ModePaiement> ReadAll(string? filtre)
    {
        var l = new List<ModePaiement>();
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_ModePaiement_ReadAll");
        cmd.Parameters.AddWithValue("@p_filtre", Sql.Txt(filtre));
        cn.Open();
        using var r = cmd.ExecuteReader();
        while (r.Read()) l.Add(new ModePaiement { ModePaiementId = r.Int("modePaiementId"), MpLibelle = r.Str("mpLibelle") });
        return l;
    }

    public static ModePaiement? ReadById(int id)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_ModePaiement_ReadById");
        cmd.Parameters.AddWithValue("@p_id", id);
        cn.Open();
        using var r = cmd.ExecuteReader();
        return r.Read() ? new ModePaiement { ModePaiementId = r.Int("modePaiementId"), MpLibelle = r.Str("mpLibelle") } : null;
    }

    public static void Update(ModePaiement m)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_ModePaiement_Update");
        cmd.Parameters.AddWithValue("@p_id", m.ModePaiementId);
        cmd.Parameters.AddWithValue("@p_libelle", Sql.Txt(m.MpLibelle));
        cn.Open();
        cmd.ExecuteNonQuery();
    }

    public static void Delete(int id)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_ModePaiement_Delete");
        cmd.Parameters.AddWithValue("@p_id", id);
        cn.Open();
        cmd.ExecuteNonQuery();
    }
}

public static class CategorieDAO
{
    static Categorie Mapper(MySqlDataReader r) =>
        new Categorie { CategorieId = r.Int("categorieId"), CatLibelle = r.Str("catLibelle"), CatType = r.Str("catType") };

    public static int Create(Categorie c)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Categorie_Create");
        cmd.Parameters.AddWithValue("@p_libelle", Sql.Txt(c.CatLibelle));
        cmd.Parameters.AddWithValue("@p_type", c.CatType);
        var pId = Sql.Sortie(cmd, "@p_id");
        cn.Open();
        cmd.ExecuteNonQuery();
        return Sql.Id(pId);
    }

    /// <param name="type">null = toutes ; "RECETTE" ou "DEPENSE"</param>
    public static List<Categorie> ReadAll(string? filtre, string? type = null)
    {
        var l = new List<Categorie>();
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Categorie_ReadAll");
        cmd.Parameters.AddWithValue("@p_filtre", Sql.Txt(filtre));
        cmd.Parameters.AddWithValue("@p_type", Sql.Txt(type));
        cn.Open();
        using var r = cmd.ExecuteReader();
        while (r.Read()) l.Add(Mapper(r));
        return l;
    }

    public static Categorie? ReadById(int id)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Categorie_ReadById");
        cmd.Parameters.AddWithValue("@p_id", id);
        cn.Open();
        using var r = cmd.ExecuteReader();
        return r.Read() ? Mapper(r) : null;
    }

    public static void Update(Categorie c)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Categorie_Update");
        cmd.Parameters.AddWithValue("@p_id", c.CategorieId);
        cmd.Parameters.AddWithValue("@p_libelle", Sql.Txt(c.CatLibelle));
        cmd.Parameters.AddWithValue("@p_type", c.CatType);
        cn.Open();
        cmd.ExecuteNonQuery();
    }

    public static void Delete(int id)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Categorie_Delete");
        cmd.Parameters.AddWithValue("@p_id", id);
        cn.Open();
        cmd.ExecuteNonQuery();
    }
}

public static class CentreImputationDAO
{
    static CentreImputation Mapper(MySqlDataReader r) => new CentreImputation
    {
        CentreId = r.Int("centreId"),
        CtrCode = r.Str("ctrCode"),
        CtrLibelle = r.Str("ctrLibelle"),
        CtrResponsable = r.StrN("ctrResponsable"),
        CtrDescription = r.StrN("ctrDescription"),
        CtrActif = r.Bool("ctrActif")
    };

    public static int Create(CentreImputation c)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Centre_Create");
        cmd.Parameters.AddWithValue("@p_code", Sql.Txt(c.CtrCode));
        cmd.Parameters.AddWithValue("@p_libelle", Sql.Txt(c.CtrLibelle));
        cmd.Parameters.AddWithValue("@p_responsable", Sql.Txt(c.CtrResponsable));
        cmd.Parameters.AddWithValue("@p_description", Sql.Txt(c.CtrDescription));
        cmd.Parameters.AddWithValue("@p_actif", Sql.Bool(c.CtrActif));
        var pId = Sql.Sortie(cmd, "@p_id");
        cn.Open();
        cmd.ExecuteNonQuery();
        return Sql.Id(pId);
    }

    public static List<CentreImputation> ReadAll(string? filtre, bool? actif = null)
    {
        var l = new List<CentreImputation>();
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Centre_ReadAll");
        cmd.Parameters.AddWithValue("@p_filtre", Sql.Txt(filtre));
        cmd.Parameters.AddWithValue("@p_actif", Sql.Bool(actif));
        cn.Open();
        using var r = cmd.ExecuteReader();
        while (r.Read()) l.Add(Mapper(r));
        return l;
    }

    public static CentreImputation? ReadById(int id)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Centre_ReadById");
        cmd.Parameters.AddWithValue("@p_id", id);
        cn.Open();
        using var r = cmd.ExecuteReader();
        return r.Read() ? Mapper(r) : null;
    }

    public static void Update(CentreImputation c)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Centre_Update");
        cmd.Parameters.AddWithValue("@p_id", c.CentreId);
        cmd.Parameters.AddWithValue("@p_code", Sql.Txt(c.CtrCode));
        cmd.Parameters.AddWithValue("@p_libelle", Sql.Txt(c.CtrLibelle));
        cmd.Parameters.AddWithValue("@p_responsable", Sql.Txt(c.CtrResponsable));
        cmd.Parameters.AddWithValue("@p_description", Sql.Txt(c.CtrDescription));
        cmd.Parameters.AddWithValue("@p_actif", Sql.Bool(c.CtrActif));
        cn.Open();
        cmd.ExecuteNonQuery();
    }

    public static void Delete(int id)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Centre_Delete");
        cmd.Parameters.AddWithValue("@p_id", id);
        cn.Open();
        cmd.ExecuteNonQuery();
    }
}
