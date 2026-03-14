using IdnesPlaywright.MainPage;
using IdnesPlaywright.Setup;

namespace IdnesPlaywright.Tests.MainPage
{
    public class UpperBannerButtonsVisibility : BaseTest
    {
        protected ElementActions _mpElementActions;
        protected ICookiesButtons _cButtons;
        protected IUpperBannerButtons _mpBannerButtons;
        protected MainPageLocators _mpLocators;

        [SetUp]
        public void SetupPageObjects()
        {
            _mpElementActions = new ElementActions(Page);
            _cButtons = new CookiesButtons(_mpElementActions);
            _mpBannerButtons = new UpperBannerButtons(_mpElementActions);
            _mpLocators = new MainPageLocators();            
        }

        //Visibility tests
        [Test]
        public async Task ButtonZpravyVisible_ShouldPass()
        {
            await _cButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerZpravyButtonVisible();
        }

        [Test]
        public async Task ButtonKrajeVisible_ShouldPass()
        {
            await _cButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerKrajeButtonVisible();
        }

        [Test]
        public async Task ButtonSportVisible_ShouldPass()
        {
            await _cButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerSportButtonVisible();
        }

        [Test]
        public async Task ButtonMagazinyVisible_ShouldPass()
        {
            await _cButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerMagazinyButtonVisible();
        }

        [Test]
        public async Task ButtonRevueVisible_ShouldPass()
        {
            await _cButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerRevueButtonVisible();
        }

        [Test]
        public async Task ButtonVideoVisible_ShouldPass()
        {
            await _cButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerVideoButtonVisible();
        }

        [Test]
        public async Task ButtonPremiumVisible_ShouldPass()
        {
            await _cButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerPremiumButtonVisible();
        }

        [Test]
        public async Task ButtonSpotrebitelVisible_ShouldPass()
        {
            await _cButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerSpotrebitelButtonVisible();
        }

        [Test]
        public async Task ButtonZabavaVisible_ShouldPass()
        {
            await _cButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerZabavaButtonVisible();
        }

        [Test]
        public async Task ButtonExpresVisible_ShouldPass()
        {
            await _cButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerButtons.UpperBannerExpresButtonVisible();
        }
    }
}
