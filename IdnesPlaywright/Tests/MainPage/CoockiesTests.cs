using IdnesPlaywright.MainPage;
using IdnesPlaywright.Setup;

namespace IdnesPlaywright.Tests.MainPage
{
    public class CoockiesTests : BaseTest
    {           
        protected IElementActions _mpElementActions;
        protected ICookiesButtons _cButtons;        
        
        [SetUp]
        public void SetupPageObjects()
        {
            _mpElementActions = new ElementActions(Page);
            _cButtons = new CookiesButtons(_mpElementActions);
        }

        [Test]
        public async Task GoToIdnesMainPageTest_ShouldPass()
        {
            await _cButtons.GoToIdnesMainPage();            
        }

        [Test]
        public async Task GoToCookiesSite()
        {
            await _cButtons.GoToIdnesMainPage();
            await _cButtons.GoToSetupCookies();
        }

        [Test]
        public async Task GoToInitialPageAcceptAllCookies()
        {
            await _cButtons.GoToIdnesMainPageAscceptAllCookies();            
        }

        [Test]
        public async Task DetailedCookiesSettingsButtonClick_ShouldPass()
        {
            await _cButtons.DetailedCookiesSettingsButtonClick();
        }
    }
}
