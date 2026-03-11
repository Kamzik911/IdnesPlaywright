using IdnesPlaywright.MainPage;
using IdnesPlaywright.Setup;

namespace IdnesPlaywright.Tests
{
    public class MainPageTests : BaseTest
    {           
        protected IElementActions _mpElementActions;
        protected IMainPageButtons _mpButtons;        
        
        [SetUp]
        public void SetupPageObjects()
        {
            _mpElementActions = new ElementActions(Page);
            _mpButtons = new MainPageButtons(_mpElementActions);
        }

        [Test]
        public async Task GoToIdnesMainPageTest_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPage();            
        }

        [Test]
        public async Task GoToCookiesSite()
        {
            await _mpButtons.GoToIdnesMainPage();
            await _mpButtons.GoToSetupCookies();
        }

        [Test]
        public async Task GoToInitialPageAcceptAllCookies()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();            
        }

        [Test]
        public async Task CheckZpravyButtonVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpButtons.UpperBannerZpravyButton();
        }

        [Test]
        public async Task CheckKrajeButtonVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpButtons.UpperBannerKrajeButton();
        }

        [Test]
        public async Task CheckSportButtonVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpButtons.UpperBannerSportButton();
        }
    }
}
