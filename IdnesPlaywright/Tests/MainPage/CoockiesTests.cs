using IdnesPlaywright.MainPage;
using IdnesPlaywright.Setup;

namespace IdnesPlaywright.Tests.MainPage
{
    public class CoockiesTests : BaseTest
    {           
        //For NON headless mode


        protected IUiActions _mpElementActions;
        protected ICookiesButtons _cButtons;        
        
        [SetUp]
        public void SetupPageObjects()
        {
            _mpElementActions = new UiActions(Page);
            _cButtons = new CookiesButtons(_mpElementActions);
        }

        [Test]
        [Category("HeadlessFalse")]
        public async Task GoToIdnesMainPageTest_ShouldPass()
        {
            await _cButtons.GoToIdnesMainPage();            
        }

        [Test]
        [Category("HeadlessFalse")]
        public async Task GoToCookiesSite()
        {
            await _cButtons.GoToIdnesMainPage();
            await _cButtons.GoToSetupCookies();
        }

        [Test]
        [Category("HeadlessFalse")]
        public async Task GoToInitialPageAcceptAllCookies()
        {
            await _cButtons.GoToIdnesMainPageAscceptAllCookies();            
        }

        [Test]
        [Category("HeadlessFalse")]
        public async Task DetailedCookiesSettingsButtonClick_ShouldPass()
        {
            await _cButtons.DetailedCookiesSettingsButtonClick();
        }

        [Test]
        [Category("HeadlessFalse")]
        public async Task UkladaniANeboPristupKInfVZarizeniClick_ShouldPass()
        {
            await _cButtons.UkladaniANeboPristupKInfVZarizeniNesouhlasitClick();
        }

        [Test]
        [Category("HeadlessFalse")]
        public async Task UkladaniANeboPristupKInfVZarizeniSouhlasitClick_ShouldPass()
        {
            await _cButtons.UkladaniANeboPristupKInfVZarizeniSouhlasitClick();
        }

        [Test]
        [Category("HeadlessFalse")]
        public async Task PersonalisovanaReklamaAObsahSouhlasit_ShouldPass()
        {
            await _cButtons.PersonalisovanaReklamaAObsahSouhlasit();
        }

        [Test]
        [Category("HeadlessFalse")]
        public async Task PersonalisovanaReklamaAObsahNesouhlasit_ShouldPass()
        {
            await _cButtons.PersonalisovanaReklamaAObsahNesouhlasit();
        }

        [Test]
        [Category("HeadlessFalse")]
        public async Task ZpracovaniUdajuVydavateliAPartnerySouhlasit_ShouldPass()
        {
            await _cButtons.ZpracovaniUdajuVydavateliAPartnerySouhlasit();
        }
    }
}
