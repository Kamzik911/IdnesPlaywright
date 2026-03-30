using Microsoft.Playwright;

namespace IdnesPlaywright.Setup
{
    public interface IUiActions
    {
        Task GoToWebPage(string webPage);
        Task GotoWebPageCheckExpectPage(string url, string expectedUrl);
        ILocator FindLocator(string selectLocator);
        Task FillElement(string selectLocator, string textToElement);
        Task FillElementAndCheckValue(string selectLocator, string textToElement);
        ILocator FindLocatorByTextString(string selectLocator, string textString);
        ILocator FindLocatorByExactTextString(string selectLocator, string textString);
        Task<int> FindLocatorCount(ILocator locator);
        ILocator FindLocatorByLink(string selectLocator);
        ILocator FindLocatorByButton(string selectLocator);
        Task CheckLocatorVisibility(string selectLocator);
        Task CheckAriaHeadingVisibility(string selectLocator);
        Task CheckAriaLinkVisibility(string selectLocator);
        Task CheckAriaButtonVisibility(string selectLocator);
        Task FindLocatorAndClick(string selectLocator);
        Task FindLocatorByLinkRoleAndClick(string selectLocator);
        Task FindLocatorByTextStringClick(string selectLocator, string textString);
        Task FindLocatorByExactTextStringClick(string selectLocator, string textString);
        Task FindLocatorByRoleButtonCheckVisible(string selectLocator);
    }
}
