namespace IdnesPlaywright.MainPage
{
    public class MainPageLocators
    {
        public static string MainPageIdnes = "https://www.idnes.cz/";
        public string InitialPageIdnes = MainPageIdnes;

        //Cookie settings page
        public string CookieSettingsPage = "Pro pokračování vyberte, jakou formou vám máme zobrazovat obsah.";

        public string AcceptAllCookiesButton = "Souhlasím";

        //Upper banner (menu2024-standard)
        public static string UpperBannerZpravyButton = "zpravy";        
        public static string UpperBannerKrajeButton = "kraje";
        public static string UpperBannerSportButton = "sport";

        public string ZpravyButton = $"a[href='{MainPageIdnes}{UpperBannerZpravyButton}'][title='Zprávy']";
        public string KrajeButton = $"a[href='{MainPageIdnes}{UpperBannerKrajeButton}'][score-place='2'][title='Kraje']";
        public string SportButton = $"a[href='{MainPageIdnes}{UpperBannerSportButton}'][title='Sport']";
    }
}
