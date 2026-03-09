using Microsoft.Playwright;

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

        public async Task ClickOnElement(string selectLocator)
        {
            await _page.ClickAsync(selectLocator);            
        }

        public async Task FindLocatorAndClick(string selectLocator)
        {
            var element = FindLocator(selectLocator);                        
            await ClickOnElement(selectLocator);            
        }
    }
}
