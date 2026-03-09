using Microsoft.Playwright;

namespace IdnesPlaywright.MainPage
{
    public interface IMainPageElementActions
    {
        Task GoToWebPage(string webPage);
        Task<ILocator> FindLocator(string selectLocator);
        Task ClickOnElement(string selectLocator);
        Task FindLocatorAndClick(string selectLocator);
    }

    public interface IMainPageButtons
    {
            Task GoToIdnesMainPage();
    }
}
