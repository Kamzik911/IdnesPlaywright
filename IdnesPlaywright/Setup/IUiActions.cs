using Microsoft.Playwright;

namespace IdnesPlaywright.Setup
{
    public interface IUiActions
    {
        Task GoToWebPage(string webPage);
        ILocator FindLocator(string selectLocator);
        ILocator FindLocatorByTextString(string selectLocator, string textString);
        ILocator FindLocatorByExactTextString(string selectLocator, string textString);
        Task<int> GetLocatorCount(ILocator locator);
        ILocator GetLocatorByLink(string selectLocator);
        Task CheckLocatorVisibility(string selectLocator);
        Task FindLocatorAndClick(string selectLocator);
        Task GetLocatorByLinkRoleAndClick(string selectLocator);
        Task GetLocatorByTextStringClick(string selectLocator, string textString);
        Task GetFindLocatorByExactTextStringClick(string selectLocator, string textString);
    }
}
