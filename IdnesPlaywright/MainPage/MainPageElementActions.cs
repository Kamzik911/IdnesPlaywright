using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;

namespace IdnesPlaywright.MainPage
{
    public class MainPageElementActions : IMainPageElementActions
    {
        private readonly IPage _page;
        public MainPageElementActions(IPage page) 
        {
            _page = page;
        }

        public async Task GoToWebPage(string webPage)
        {
            await _page.GotoAsync(webPage);
        }

        public ILocator FindLocator(string selectLocator)
        {
            return _page.Locator(selectLocator);
        }

        public async Task<int> GetLocatorCount(ILocator locator)
        {            
            return await locator.CountAsync();
        }

        public ILocator GetLocatorByLinkRole(string selectLocator)
        {
            return _page.GetByRole(AriaRole.Link, new()
            {
                Name = selectLocator
            });                 
        }

        public async Task FindLocatorAndClick(string selectLocator)
        {
            var element = FindLocator(selectLocator);            
            await element.ClickAsync();
        }

        public async Task GetLocatorByLinkRoleAndClick(string selectLocator)
        {
            var elemelement = GetLocatorByLinkRole(selectLocator);
            await elemelement.ClickAsync();
        }
    }
}
