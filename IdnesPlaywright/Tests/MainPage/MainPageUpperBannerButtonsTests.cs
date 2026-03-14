using IdnesPlaywright.MainPage;
using IdnesPlaywright.Setup;

namespace IdnesPlaywright.Tests.MainPage
{
    public class MainPageUpperBannerButtonsTests : BaseTest
    {
        protected ElementActions _mpElementActions;
        protected IMainPageButtons _mpButtons;
        protected IMainPageBannerButtons _mpBannerButtons;
        protected MainPageLocators _mpLocators;

        [SetUp]
        public void SetupPageObjects()
        {
            _mpElementActions = new ElementActions(Page);
            _mpButtons = new MainPageButtons(_mpElementActions);
            _mpLocators = new MainPageLocators();
            _mpBannerButtons = new UpperBannerButtons(_mpElementActions, _mpLocators);
        }

        [Test]
        public async Task CheckZpravyButtonVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerZpravyButton();
        }

        [Test]
        public async Task ButtonKrajeVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerKrajeButton();
        }

        [Test]
        public async Task ButtonSportVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerSportButton();
        }

        [Test]
        public async Task ButtonMagazinyVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerMagazinyButton();
        }

        [Test]
        public async Task ButtonRevueVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerRevueButton();
        }

        [Test]
        public async Task ButtonVideoVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerVideoButton();
        }

        [Test]
        public async Task ButtonPremiumVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerPremiumButton();
        }

        [Test]
        public async Task ButtonSpotrebitelVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerSpotrebitelButton();
        }

        [Test]
        public async Task ButtonZabavaVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerZabavaButton();
        }

        [Test]
        public async Task ButtonExpresVisible_ShouldPass()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerExpresButton();
        }
    }
}
