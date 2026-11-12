using System.Globalization;

namespace MiniTresorerie.UInterface;

static class Program
{
    [STAThread]
    static void Main()
    {
        // Culture française avec espace comme séparateur de milliers : 1 250 000
        var ci = (CultureInfo)new CultureInfo("fr-FR").Clone();
        ci.NumberFormat.NumberGroupSeparator = " ";
        ci.NumberFormat.CurrencyGroupSeparator = " ";
        CultureInfo.DefaultThreadCurrentCulture = ci;
        CultureInfo.DefaultThreadCurrentUICulture = ci;
        CultureInfo.CurrentCulture = ci;

        ApplicationConfiguration.Initialize();

        using (var splash = new FrmDemarrage())
        {
            if (splash.ShowDialog() != DialogResult.OK) return;
        }

        while (true)
        {
            using (var login = new FrmConnexion())
            {
                if (login.ShowDialog() != DialogResult.OK) break;
            }
            using var principal = new FrmPrincipal();
            Application.Run(principal);
            if (!principal.Deconnexion) break;
            Session.Utilisateur = null;
        }
    }
}
