namespace IdnesPlaywright.MainPage
{
    public interface ICookiesButtons
    {
        Task GoToIdnesMainPage();
        Task GoToSetupCookies();
        Task GoToIdnesMainPageAscceptAllCookies();
        Task GoToDetailedCookiesSettings();
        Task DetailedCookiesSettingsButtonClick();
    }
}
