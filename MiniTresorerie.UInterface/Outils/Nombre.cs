namespace MiniTresorerie.UInterface;

/// <summary>Conversion d'un montant en lettres (français) pour les reçus et bons de caisse.</summary>
public static class Nombre
{
    static readonly string[] U =
    {
        "zéro", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze",
        "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf"
    };
    static readonly string[] D = { "", "", "vingt", "trente", "quarante", "cinquante", "soixante" };

    static string Moins100(int x)
    {
        if (x < 20) return U[x];
        int diz = x / 10, un = x % 10;
        if (diz == 7 || diz == 9)
        {
            int r = x - (diz == 7 ? 60 : 80);
            string b = diz == 7 ? "soixante" : "quatre-vingt";
            if (diz == 7 && r == 11) return "soixante et onze";
            return b + "-" + U[r];
        }
        if (diz == 8) return un == 0 ? "quatre-vingts" : "quatre-vingt-" + U[un];
        if (un == 0) return D[diz];
        if (un == 1) return D[diz] + " et un";
        return D[diz] + "-" + U[un];
    }

    static string Moins1000(int x)
    {
        int c = x / 100, r = x % 100;
        if (c == 0) return Moins100(r);
        if (c == 1) return r == 0 ? "cent" : "cent " + Moins100(r);
        return U[c] + " cent" + (r == 0 ? "s" : " " + Moins100(r));
    }

    static string SansS(string s) => (s.EndsWith("cents") || s.EndsWith("vingts")) ? s[..^1] : s;

    public static string EnLettres(long n)
    {
        if (n == 0) return "zéro";
        if (n < 0) return "moins " + EnLettres(-n);
        var parts = new List<string>();
        int milliards = (int)(n / 1_000_000_000);
        int millions = (int)((n / 1_000_000) % 1000);
        int milliers = (int)((n / 1000) % 1000);
        int reste = (int)(n % 1000);
        if (milliards > 0) parts.Add(Moins1000(milliards) + (milliards > 1 ? " milliards" : " milliard"));
        if (millions > 0) parts.Add(Moins1000(millions) + (millions > 1 ? " millions" : " million"));
        if (milliers > 0) parts.Add(milliers == 1 ? "mille" : SansS(Moins1000(milliers)) + " mille");
        if (reste > 0) parts.Add(Moins1000(reste));
        string s = string.Join(" ", parts);
        return char.ToUpper(s[0]) + s[1..];
    }
}
