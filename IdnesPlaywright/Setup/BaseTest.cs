using Microsoft.Playwright;

namespace IdnesPlaywright.Setup
{
    public abstract class BaseTest
    {
        protected IPlaywright Playwright = null!;
        protected IBrowser Browser = null!;
        protected IBrowserContext BrowserContext = null!;
        protected IPage Page = null!;

        [OneTimeSetUp]
        public async Task OneTimeSetup()
        {
            Playwright = await Microsoft.Playwright.Playwright.CreateAsync();

            var browserFactory = new SelectBrowser(Playwright);
            Browser = await browserFactory.SetBrowser(Browsers.Chromium);
        }

        [SetUp]
        public async Task Setup()
        {
            BrowserContext = await Browser.NewContextAsync(new BrowserNewContextOptions
            {
                ViewportSize = new ViewportSize
                {
                    Width = 1920,
                    Height = 1080,
                }
            });
            
            Page = await BrowserContext.NewPageAsync();
        }

        [TearDown]
        public async Task TearDown()
        {
            await BrowserContext.CloseAsync();
        }

        [OneTimeTearDown]
        public async Task OneTimeTearDown()
        {
            await Browser.CloseAsync();
            Playwright.Dispose();
        }
    }
}
