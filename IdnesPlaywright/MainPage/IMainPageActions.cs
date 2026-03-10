using Microsoft.Playwright;

namespace IdnesPlaywright.MainPage
{
    public interface IMainPageElementActions
    {
        Task GoToWebPage(string webPage);
        ILocator FindLocator(string selectLocator);      
        ILocator GetLocatorByLinkRole(string selectLocator);
        Task FindLocatorAndClick(string selectLocator);
        Task GetLocatorByLinkRoleAndClick(string selectLocator);
    }

    public interface IMainPageButtons
    {
        Task GoToIdnesMainPage();
        Task GoToSetupCookies();
    }
}
