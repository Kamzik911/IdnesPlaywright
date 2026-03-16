using IdnesPlaywright.MainPage;
using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;

namespace IdnesPlaywright.Setup
{
    public class UiActions : IUiActions
    {
        private readonly IPage _page;
        public UiActions(IPage page) 
        {
            _page = page;
        }

        public async Task GoToWebPage(string url)
        {
            await _page.GotoAsync(url);
        }

        public ILocator FindLocator(string selectLocator)
        {
            return _page.Locator(selectLocator);
        }

        public ILocator FindLocatorByTextString(string selectLocator, string textString)
        {
            return _page.Locator(selectLocator).Filter(new() { HasTextString = textString });
        }

        public ILocator FindLocatorByExactTextString(string selectLocator, string textString)
        {
            return _page.Locator(selectLocator).Filter(new()
            {
                HasTextRegex = new Regex($"^{Regex.Escape(textString)}$")
            });
        }

        public async Task<int> GetLocatorCount(ILocator locator)
        {            
            return await locator.CountAsync();
        }

        public ILocator GetLocatorByLink(string selectLocator)
        {
            return _page.GetByRole(AriaRole.Link, new() { Name = selectLocator });                 
        }

        public ILocator GetLocatorByRadio(string selectLocator)
        {
            return _page.GetByRole(AriaRole.Radio, new() { Name = selectLocator });
        }

        public async Task CheckLocatorVisibility(string selectLocator)
        {
            var element = FindLocator(selectLocator);
            await Expect(element).ToBeVisibleAsync();
        }

        public async Task FindLocatorAndClick(string selectLocator)
        {
            var element = FindLocator(selectLocator);            
            await element.ClickAsync();
        }

        public async Task GetLocatorByLinkRoleAndClick(string selectLocator)
        {
            var elemelement = GetLocatorByLink(selectLocator);
            await elemelement.ClickAsync();
        }

        public async Task GetLocatorByTextStringClick(string selectLocator, string textString)
        {
            var element = FindLocatorByTextString(selectLocator, textString);
            await element.ClickAsync();
        }

        public async Task GetFindLocatorByExactTextStringClick(string selectLocator, string textString)
        {
            var element = FindLocatorByExactTextString(selectLocator, textString);
            await element.ClickAsync();
        }


    }
}
