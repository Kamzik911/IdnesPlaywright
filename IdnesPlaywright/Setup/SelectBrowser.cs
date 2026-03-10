using Microsoft.Playwright;

namespace IdnesPlaywright.Setup
{
    public class SelectBrowser
    {
        private readonly IPlaywright _playwright;

        public SelectBrowser(IPlaywright playwright)
        {
            _playwright = playwright;
        }

        public async Task<IBrowser> SetBrowser(Browsers selectedBrowser)
        {
            return selectedBrowser switch
            {
                Browsers.Chromium => await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false,
                    SlowMo = 250
                }),

                Browsers.Firefox => await _playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false
                }),

                Browsers.Webkit => await _playwright.Webkit.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = false
                }),

                _ => throw new ArgumentOutOfRangeException(nameof(selectedBrowser), selectedBrowser, null)
            };
        }        
    }
}
