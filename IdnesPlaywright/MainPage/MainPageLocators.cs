namespace IdnesPlaywright.MainPage
{
    public class MainPageLocators
    {
        public static string IdnesMainPage = "https://www.idnes.cz/";
        public string InitialPageIdnes = IdnesMainPage;

        public static string IdnesVideoPage = "https://tv.idnes.cz";

        //Cookie settings page
        public string CookieSettingsPage = "Pro pokračování vyberte, jakou formou vám máme zobrazovat obsah.";

        public string AcceptAllCookiesButton = "Souhlasím";

        //Upper banner (menu2024-standard)
        public static string UpperBannerZpravyButton = "zpravy";        
        public static string UpperBannerKrajeButton = "kraje";
        public static string UpperBannerSportButton = "sport";
        public static string UpperBannerMagazinyButton = "magaziny";
        public static string UpperBannerRevueButton = "revue";
        public static string UpperBannerPremiumButton = "premium?zdroj=menu";
        public static string UpperBannerSpotrebitelButton = "spotrebitel";

        public string ZpravyButton = $"a[href='{IdnesMainPage}{UpperBannerZpravyButton}'][title='Zprávy']";
        public string KrajeButton = $"a[href='{IdnesMainPage}{UpperBannerKrajeButton}'][score-place='2'][title='Kraje']";
        public string SportButton = $"a[href='{IdnesMainPage}{UpperBannerSportButton}'][title='Sport']";
        public string MagazinyButton = $"a[href='{IdnesMainPage}{UpperBannerMagazinyButton}'][title='Magazíny']";
        public string RevueButton = $"a[href='{IdnesMainPage}{UpperBannerRevueButton}'][title='Revue']";
        public string VideoButton = $"a[href='{IdnesVideoPage}'][title='Video']";
        public string PremiumButton = $"a[href='{IdnesMainPage}{UpperBannerPremiumButton}'][title='Premium']";
        public string SpotrebitelButton = $"a[href='{IdnesMainPage}{UpperBannerSpotrebitelButton}'][title='Spotřebitel']";

    }
}