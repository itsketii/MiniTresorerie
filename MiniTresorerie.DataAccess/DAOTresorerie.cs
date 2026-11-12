using MiniTresorerie.Models;
using MySql.Data.MySqlClient;

namespace MiniTresorerie.DataAccess;

public static class CompteTresorerieDAO
{
    static CompteTresorerie Mapper(MySqlDataReader r) => new CompteTresorerie
    {
        CompteId = r.Int("compteId"),
        CptCode = r.Str("cptCode"),
        CptLibelle = r.Str("cptLibelle"),
        TypeCompteId = r.Int("typeCompteId"),
        TcLibelle = r.Str("tcLibelle"),
        CptDevise = r.Str("cptDevise"),
        CptSoldeInitial = r.Dec("cptSoldeInitial"),
        CptDateOuverture = r.Date("cptDateOuverture"),
        CptActif = r.Bool("cptActif"),
        CptDescription = r.StrN("cptDescription"),
        CptSolde = r.Dec("cptSolde")
    };

    static void Remplir(MySqlCommand cmd, CompteTresorerie c)
    {
        cmd.Parameters.AddWithValue("@p_code", Sql.Txt(c.CptCode));
        cmd.Parameters.AddWithValue("@p_libelle", Sql.Txt(c.CptLibelle));
        cmd.Parameters.AddWithValue("@p_typeCompteId", c.TypeCompteId);
        cmd.Parameters.AddWithValue("@p_devise", Sql.Txt(c.CptDevise));
        cmd.Parameters.AddWithValue("@p_soldeInitial", c.CptSoldeInitial);
        cmd.Parameters.AddWithValue("@p_dateOuverture", c.CptDateOuverture.Date);
        cmd.Parameters.AddWithValue("@p_actif", Sql.Bool(c.CptActif));
        cmd.Parameters.AddWithValue("@p_description", Sql.Txt(c.CptDescription));
    }

    public static int Create(CompteTresorerie c)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Compte_Create");
        Remplir(cmd, c);
        var pId = Sql.Sortie(cmd, "@p_id");
        cn.Open();
        cmd.ExecuteNonQuery();
        return Sql.Id(pId);
    }

    public static List<CompteTresorerie> ReadAll(string? filtre, bool? actif = null)
    {
        var l = new List<CompteTresorerie>();
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Compte_ReadAll");
        cmd.Parameters.AddWithValue("@p_filtre", Sql.Txt(filtre));
        cmd.Parameters.AddWithValue("@p_actif", Sql.Bool(actif));
        cn.Open();
        using var r = cmd.ExecuteReader();
        while (r.Read()) l.Add(Mapper(r));
        return l;
    }

    public static CompteTresorerie? ReadById(int id)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Compte_ReadById");
        cmd.Parameters.AddWithValue("@p_id", id);
        cn.Open();
        using var r = cmd.ExecuteReader();
        return r.Read() ? Mapper(r) : null;
    }

    public static void Update(CompteTresorerie c)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Compte_Update");
        cmd.Parameters.AddWithValue("@p_id", c.CompteId);
        Remplir(cmd, c);
        cn.Open();
        cmd.ExecuteNonQuery();
    }

    public static void Delete(int id)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Compte_Delete");
        cmd.Parameters.AddWithValue("@p_id", id);
        cn.Open();
        cmd.ExecuteNonQuery();
    }
}

public static class MouvementDAO
{
    static Mouvement Mapper(MySqlDataReader r) => new Mouvement
    {
        MouvementId = r.Int("mouvementId"),
        MvtReference = r.Str("mvtReference"),
        MvtDate = r.Date("mvtDate"),
        MvtType = r.Str("mvtType"),
        MvtLibelle = r.Str("mvtLibelle"),
        MvtMontant = r.Dec("mvtMontant"),
        CompteId = r.Int("compteId"),
        CptCode = r.Str("cptCode"),
        CptLibelle = r.Str("cptLibelle"),
        CategorieId = r.Int("categorieId"),
        CatLibelle = r.Str("catLibelle"),
        CentreId = r.IntN("centreId"),
        CtrCode = r.Str("ctrCode"),
        CtrLibelle = r.Str("ctrLibelle"),
        ModePaiementId = r.Int("modePaiementId"),
        MpLibelle = r.Str("mpLibelle"),
        MvtTiers = r.StrN("mvtTiers"),
        MvtPiece = r.StrN("mvtPiece"),
        MvtRapproche = r.Bool("mvtRapproche"),
        MvtDateRapprochement = r.DateN("mvtDateRapprochement"),
        UtilisateurId = r.Int("utilisateurId"),
        UsrLogin = r.Str("usrLogin"),
        MvtDateSaisie = r.Date("mvtDateSaisie")
    };

    static void Remplir(MySqlCommand cmd, Mouvement m)
    {
        cmd.Parameters.AddWithValue("@p_date", m.MvtDate.Date);
        cmd.Parameters.AddWithValue("@p_type", m.MvtType);
        cmd.Parameters.AddWithValue("@p_libelle", Sql.Txt(m.MvtLibelle));
        cmd.Parameters.AddWithValue("@p_montant", m.MvtMontant);
        cmd.Parameters.AddWithValue("@p_compteId", m.CompteId);
        cmd.Parameters.AddWithValue("@p_categorieId", m.CategorieId);
        cmd.Parameters.AddWithValue("@p_centreId", Sql.Nb(m.CentreId));
        cmd.Parameters.AddWithValue("@p_modePaiementId", m.ModePaiementId);
        cmd.Parameters.AddWithValue("@p_tiers", Sql.Txt(m.MvtTiers));
        cmd.Parameters.AddWithValue("@p_piece", Sql.Txt(m.MvtPiece));
    }

    public static int Create(Mouvement m)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Mouvement_Create");
        Remplir(cmd, m);
        cmd.Parameters.AddWithValue("@p_utilisateurId", m.UtilisateurId);
        var pId = Sql.Sortie(cmd, "@p_id");
        cn.Open();
        cmd.ExecuteNonQuery();
        return Sql.Id(pId);
    }

    public static List<Mouvement> ReadAll(MouvementFiltre? f = null)
    {
        f ??= new MouvementFiltre();
        var l = new List<Mouvement>();
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Mouvement_ReadAll");
        cmd.Parameters.AddWithValue("@p_filtre", Sql.Txt(f.Texte));
        cmd.Parameters.AddWithValue("@p_debut", Sql.Dt(f.DateDebut));
        cmd.Parameters.AddWithValue("@p_fin", Sql.Dt(f.DateFin));
        cmd.Parameters.AddWithValue("@p_compteId", Sql.Nb(f.CompteId));
        cmd.Parameters.AddWithValue("@p_centreId", Sql.Nb(f.CentreId));
        cmd.Parameters.AddWithValue("@p_type", Sql.Txt(f.Type));
        cmd.Parameters.AddWithValue("@p_rapproche", Sql.Bool(f.Rapproche));
        cn.Open();
        using var r = cmd.ExecuteReader();
        while (r.Read()) l.Add(Mapper(r));
        return l;
    }

    public static Mouvement? ReadById(int id)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Mouvement_ReadById");
        cmd.Parameters.AddWithValue("@p_id", id);
        cn.Open();
        using var r = cmd.ExecuteReader();
        return r.Read() ? Mapper(r) : null;
    }

    public static void Update(Mouvement m)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Mouvement_Update");
        cmd.Parameters.AddWithValue("@p_id", m.MouvementId);
        Remplir(cmd, m);
        cn.Open();
        cmd.ExecuteNonQuery();
    }

    public static void Delete(int id)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Mouvement_Delete");
        cmd.Parameters.AddWithValue("@p_id", id);
        cn.Open();
        cmd.ExecuteNonQuery();
    }

    /// <summary>Pointe (true) ou dépointe (false) un mouvement lors du rapprochement.</summary>
    public static void Rapprocher(int id, bool etat)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Mouvement_Rapprocher");
        cmd.Parameters.AddWithValue("@p_id", id);
        cmd.Parameters.AddWithValue("@p_etat", etat ? 1 : 0);
        cn.Open();
        cmd.ExecuteNonQuery();
    }
}

public static class UtilisateurDAO
{
    static Utilisateur Mapper(MySqlDataReader r) => new Utilisateur
    {
        UtilisateurId = r.Int("utilisateurId"),
        UsrNom = r.Str("usrNom"),
        UsrPrenom = r.Str("usrPrenom"),
        UsrLogin = r.Str("usrLogin"),
        RoleId = r.Int("roleId"),
        RoleLibelle = r.Str("roleLibelle"),
        UsrActif = r.Bool("usrActif"),
        UsrDateCreation = r.DateN("usrDateCreation"),
        UsrDerniereConnexion = r.DateN("usrDerniereConnexion")
    };

    /// <summary>Retourne l'utilisateur si identifiant + mot de passe sont valides (compte actif), sinon null.</summary>
    public static Utilisateur? Authentifier(string login, string motDePasse)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Utilisateur_Authentifier");
        cmd.Parameters.AddWithValue("@p_login", login.Trim());
        cmd.Parameters.AddWithValue("@p_mdp", motDePasse);
        cn.Open();
        using var r = cmd.ExecuteReader();
        return r.Read() ? Mapper(r) : null;
    }

    public static int Create(Utilisateur u, string motDePasse)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Utilisateur_Create");
        cmd.Parameters.AddWithValue("@p_nom", Sql.Txt(u.UsrNom));
        cmd.Parameters.AddWithValue("@p_prenom", Sql.Txt(u.UsrPrenom));
        cmd.Parameters.AddWithValue("@p_login", Sql.Txt(u.UsrLogin));
        cmd.Parameters.AddWithValue("@p_mdp", motDePasse);
        cmd.Parameters.AddWithValue("@p_roleId", u.RoleId);
        cmd.Parameters.AddWithValue("@p_actif", Sql.Bool(u.UsrActif));
        var pId = Sql.Sortie(cmd, "@p_id");
        cn.Open();
        cmd.ExecuteNonQuery();
        return Sql.Id(pId);
    }

    public static List<Utilisateur> ReadAll(string? filtre)
    {
        var l = new List<Utilisateur>();
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Utilisateur_ReadAll");
        cmd.Parameters.AddWithValue("@p_filtre", Sql.Txt(filtre));
        cn.Open();
        using var r = cmd.ExecuteReader();
        while (r.Read()) l.Add(Mapper(r));
        return l;
    }

    public static Utilisateur? ReadById(int id)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Utilisateur_ReadById");
        cmd.Parameters.AddWithValue("@p_id", id);
        cn.Open();
        using var r = cmd.ExecuteReader();
        return r.Read() ? Mapper(r) : null;
    }

    /// <param name="nouveauMotDePasse">null ou vide = mot de passe inchangé</param>
    public static void Update(Utilisateur u, string? nouveauMotDePasse)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Utilisateur_Update");
        cmd.Parameters.AddWithValue("@p_id", u.UtilisateurId);
        cmd.Parameters.AddWithValue("@p_nom", Sql.Txt(u.UsrNom));
        cmd.Parameters.AddWithValue("@p_prenom", Sql.Txt(u.UsrPrenom));
        cmd.Parameters.AddWithValue("@p_login", Sql.Txt(u.UsrLogin));
        cmd.Parameters.AddWithValue("@p_mdp", string.IsNullOrEmpty(nouveauMotDePasse) ? (object)DBNull.Value : nouveauMotDePasse);
        cmd.Parameters.AddWithValue("@p_roleId", u.RoleId);
        cmd.Parameters.AddWithValue("@p_actif", Sql.Bool(u.UsrActif));
        cn.Open();
        cmd.ExecuteNonQuery();
    }

    public static void Delete(int id)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Utilisateur_Delete");
        cmd.Parameters.AddWithValue("@p_id", id);
        cn.Open();
        cmd.ExecuteNonQuery();
    }

    public static bool ChangerMotDePasse(int id, string ancien, string nouveau)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Utilisateur_ChangerMotDePasse");
        cmd.Parameters.AddWithValue("@p_id", id);
        cmd.Parameters.AddWithValue("@p_ancien", ancien);
        cmd.Parameters.AddWithValue("@p_nouveau", nouveau);
        var pOk = Sql.Sortie(cmd, "@p_ok");
        cn.Open();
        cmd.ExecuteNonQuery();
        return Sql.Id(pOk) == 1;
    }
}

public static class StatistiquesDAO
{
    public static KpiTresorerie Kpi(DateTime debut, DateTime fin)
    {
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Stats_Kpi");
        cmd.Parameters.AddWithValue("@p_debut", debut.Date);
        cmd.Parameters.AddWithValue("@p_fin", fin.Date);
        cn.Open();
        using var r = cmd.ExecuteReader();
        if (!r.Read()) return new KpiTresorerie();
        return new KpiTresorerie
        {
            TresorerieTotale = r.Dec("tresorerieTotale"),
            TotalRecettes = r.Dec("totalRecettes"),
            TotalDepenses = r.Dec("totalDepenses"),
            NbMouvements = r.Int("nbMouvements"),
            NbNonRapproches = r.Int("nbNonRapproches"),
            NbComptes = r.Int("nbComptes")
        };
    }

    public static List<PointMensuel> Mensuel(int annee)
    {
        var l = new List<PointMensuel>();
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Stats_Mensuel");
        cmd.Parameters.AddWithValue("@p_annee", annee);
        cn.Open();
        using var r = cmd.ExecuteReader();
        while (r.Read())
            l.Add(new PointMensuel { Mois = r.Int("mois"), Recettes = r.Dec("recettes"), Depenses = r.Dec("depenses") });
        return l;
    }

    /// <param name="type">null = recettes et dépenses ; "RECETTE" ou "DEPENSE"</param>
    public static List<PartCategorie> ParCategorie(string? type, DateTime debut, DateTime fin)
    {
        var l = new List<PartCategorie>();
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Stats_ParCategorie");
        cmd.Parameters.AddWithValue("@p_type", Sql.Txt(type));
        cmd.Parameters.AddWithValue("@p_debut", debut.Date);
        cmd.Parameters.AddWithValue("@p_fin", fin.Date);
        cn.Open();
        using var r = cmd.ExecuteReader();
        while (r.Read())
            l.Add(new PartCategorie { Libelle = r.Str("libelle"), TypeCat = r.Str("typeCat"), Nb = r.Int("nb"), Total = r.Dec("total") });
        return l;
    }

    public static List<LigneCentre> ParCentre(DateTime debut, DateTime fin)
    {
        var l = new List<LigneCentre>();
        using var cn = new MySqlConnection(Connexion.Chaine);
        using var cmd = Sql.Proc(cn, "SP_Stats_ParCentre");
        cmd.Parameters.AddWithValue("@p_debut", debut.Date);
        cmd.Parameters.AddWithValue("@p_fin", fin.Date);
        cn.Open();
        using var r = cmd.ExecuteReader();
        while (r.Read())
        {
            string lib = r.Str("libelle");
            l.Add(new LigneCentre
            {
                Code = r.Str("code"),
                Libelle = lib == "Non impute" ? "Non imputé" : lib,
                Recettes = r.Dec("recettes"),
                Depenses = r.Dec("depenses")
            });
        }
        return l;
    }
}
