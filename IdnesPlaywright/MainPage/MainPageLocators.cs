namespace IdnesPlaywright.MainPage
{
    public sealed class MainPageLocators
    {
        public const string Url = "https://www.idnes.cz/";
        public string InitialPageIdnes = Url;        

        public static string IdnesVideoPage = "https://tv.idnes.cz";

        public static string IdnesExpresPage = "https://www.expres.cz";

        //Cookie settings page
        public string CookiesSettingsLink => "Nastavení";
        public string AcceptAllCookiesButton => "Souhlasím";
        public string DetailedSettingsButton1 => "Podrobné nastavení";
        public string CookieSettingsPage = "Pro pokračování vyberte, jakou formou vám máme zobrazovat obsah.";        

        //Upper banner (menu2024-standard)
        public static string UpperBannerPosition2 = "[score-place='2']";
        public static string UpperBannerZpravyButton = "zpravy";        
        public static string UpperBannerKrajeButton = "kraje";
        public static string UpperBannerSportButton = "sport";
        public static string UpperBannerMagazinyButton = "magaziny";
        public static string UpperBannerRevueButton = "revue";
        public static string UpperBannerPremiumButton = "premium?zdroj=menu";
        public static string UpperBannerSpotrebitelButton = "spotrebitel";
        public static string UpperBannerZabavaButton = "zabava";

        public string GetUpperBannerName(UpperBannerItems item) => item switch
        {
            UpperBannerItems.Zpravy => "Zprávy",
            UpperBannerItems.Kraje => "Kraje",
            UpperBannerItems.Sport => "Sport",
            UpperBannerItems.Magaziny => "Magazíny",
            UpperBannerItems.Revue => "Revue",
            UpperBannerItems.Video => "Video",
            UpperBannerItems.Premium => "Prémium",
            UpperBannerItems.Spotrebitel => "Spotřebitel",
            UpperBannerItems.Zabava => "Zábava",
            UpperBannerItems.Expres => "Expres",
            _ => throw new ArgumentOutOfRangeException(nameof(item), item, null),
        };

        public string ZpravyButton = $"a[href='{Url}{UpperBannerZpravyButton}'][title='Zprávy']";
        public string KrajeButton = $"a[href='{Url}{UpperBannerKrajeButton}']{UpperBannerPosition2}[title='Kraje']";
        public string SportButton = $"a[href='{Url}{UpperBannerSportButton}'][title='Sport']";
        public string MagazinyButton = $"a[href='{Url}{UpperBannerMagazinyButton}'][title='Magazíny']";
        public string RevueButton = $"a[href='{Url}{UpperBannerRevueButton}'][title='Revue']";
        public string VideoButton = $"a[href='{IdnesVideoPage}'][title='Video']";
        public string PremiumButton = $"a[href='{Url}{UpperBannerPremiumButton}'][title='Premium']";
        public string SpotrebitelButton = $"a[href='{Url}{UpperBannerSpotrebitelButton}'][title='Spotřebitel']";
        public string ZabavaButton = $"a[href='{Url}{UpperBannerZabavaButton}']{UpperBannerPosition2}[title='Zábava']";
        public string ExpresButton = $"a[href='{IdnesExpresPage}'][title='Expres']";

        //Cookies locators
        public static string DetailedSettingsButtonClass = "contentwall_select";
        public string DetailedSettingsButton = $"a[class='contentwall_select']";

        public string Nesouhlasit = "Nesouhlasit";
        public string Souhlasit = "Souhlasit";

        public string UkladaniANeboPristupKInfVZarizeni = "button[aria-describedby='didomi-purpose-cookies']";
        public string PersonalisovanaReklamaAObsah = "button[aria-describedby='didomi-purpose-3yybJb']";
        public string ZpracovaniUdajuVydavateliAPartnery = "button[aria-describedby='didomi-purpose-chJWPf']";
    }
}