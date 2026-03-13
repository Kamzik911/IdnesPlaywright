using Microsoft.Playwright;

namespace IdnesPlaywright.Setup
{
    public interface IElementActions
    {
        Task GoToWebPage(string webPage);
        ILocator FindLocator(string selectLocator);
        Task<int> GetLocatorCount(ILocator locator);
        ILocator GetLocatorByLink(string selectLocator);
        Task CheckLocatorVisibility(string selectLocator);
        Task FindLocatorAndClick(string selectLocator);
        Task GetLocatorByLinkRoleAndClick(string selectLocator);
    }
}
