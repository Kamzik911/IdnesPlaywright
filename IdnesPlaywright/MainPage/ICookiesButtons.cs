namespace IdnesPlaywright.MainPage
{
    public interface ICookiesButtons
    {
        Task GoToIdnesMainPage();
        Task GoToSetupCookies();
        Task GoToIdnesMainPageAscceptAllCookies();
        Task GoToDetailedCookiesSettings();
        Task DetailedCookiesSettingsButtonClick();
        Task UkladaniANeboPristupKInfVZarizeniNesouhlasitClick();
        Task UkladaniANeboPristupKInfVZarizeniSouhlasitClick();
        Task PersonalisovanaReklamaAObsahNesouhlasit();
        Task PersonalisovanaReklamaAObsahSouhlasit();
        Task ZpracovaniUdajuVydavateliAPartnerySouhlasit();
    }
}
