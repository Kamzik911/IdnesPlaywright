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
            await _page.GotoAsync(url, new()
            {
                WaitUntil = WaitUntilState.DOMContentLoaded,
                Timeout = 60000
            });            
        }        

        public async Task GotoWebPageCheckExpectPage(string url, string expectedUrl)
        {
            await GoToWebPage(url);            
            await Expect(_page).ToHaveURLAsync(new Regex(expectedUrl));
        }

        public ILocator FindLocator(string selectLocator)
        {
            return _page.Locator(selectLocator);
        }

        public async Task FillElement(string selectLocator, string textToElement)
        {
            var locator = FindLocator(selectLocator);
            await locator.FillAsync(textToElement);
        }

        public async Task FillElementAndCheckValue(string selectLocator, string textToElement)
        {
            await FillElement(selectLocator, textToElement);
            var locator = FindLocator(selectLocator);
            await Expect(locator).ToHaveValueAsync(textToElement);
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

        public async Task<int> FindLocatorCount(ILocator locator)
        {            
            return await locator.CountAsync();
        }

        public ILocator FindLocatorByLink(string selectLocator)
        {
            return _page.GetByRole(AriaRole.Link, new() { Name = selectLocator, Exact=false });                 
        }

        public ILocator FindLocatorByRadio(string selectLocator)
        {
            return _page.GetByRole(AriaRole.Radio, new() { Name = selectLocator });
        }

        public ILocator FindLocatorByButton(string selectLocator)
        {
            return _page.GetByRole(AriaRole.Button, new() { Name = selectLocator });
        }

        public ILocator FindLocatorByHeading(string selectLocator)
        {
            return _page.GetByRole(AriaRole.Heading, new() { Name = selectLocator });
        }

        public async Task CheckLocatorVisibility(string selectLocator)
        {
            var element = FindLocator(selectLocator);
            await Expect(element).ToBeVisibleAsync();
        }

        public async Task CheckAriaHeadingVisibility(string selectLocator)
        {
            var element = FindLocatorByHeading(selectLocator);
            await Expect(element).ToBeVisibleAsync();
        }
        
        public async Task CheckAriaLinkVisibility(string selectLocator)
        {
            var element = FindLocatorByLink(selectLocator);
            await Expect(element).ToBeVisibleAsync();
        }

        public async Task CheckAriaButtonVisibility(string selectLocator)
        {
            var element = FindLocatorByButton(selectLocator);
            await Expect(element).ToBeVisibleAsync();
        }

        public async Task FindLocatorAndClick(string selectLocator)
        {
            var element = FindLocator(selectLocator);
            var count = await element.CountAsync();
            Console.WriteLine($"Počet nalezených elementů: {count}");
            await element.ClickAsync();
        }

        public async Task FindLocatorByLinkRoleAndClick(string selectLocator)
        {
            var element = FindLocatorByLink(selectLocator);            
            await element.ClickAsync();
        }

        public async Task FindLocatorByTextStringClick(string selectLocator, string textString)
        {
            var element = FindLocatorByTextString(selectLocator, textString);
            await element.ClickAsync();
        }

        public async Task FindLocatorByExactTextStringClick(string selectLocator, string textString)
        {
            var element = FindLocatorByExactTextString(selectLocator, textString);
            await element.ClickAsync();
        }

        public async Task FindLocatorByRoleButtonCheckVisible(string selectLocator)
        {
            var buttonLocator = FindLocatorByButton(selectLocator);
            await Expect(buttonLocator).ToBeVisibleAsync();
        }
    }
}
