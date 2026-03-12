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
        public async Task ButtonKrajeVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpButtons.UpperBannerKrajeButton();
        }

        [Test]
        public async Task ButtonSportVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpButtons.UpperBannerSportButton();
        }

        [Test]
        public async Task ButtonMagazinyVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpButtons.UpperBannerMagazinyButton();
        }

        [Test]
        public async Task ButtonRevueVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpButtons.UpperBannerRevueButton();
        }

        [Test]
        public async Task ButtonVideoVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpButtons.UpperBannerVideoButton();
        }

        [Test]
        public async Task ButtonPremiumVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpButtons.UpperBannerPremiumButton();
        }

        [Test]
        public async Task ButtonSpotrebitelVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpButtons.UpperBannerSpotrebitelButton();
        }

    }
}
