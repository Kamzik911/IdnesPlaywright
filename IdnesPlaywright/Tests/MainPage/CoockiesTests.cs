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
        [Category("Cookies")]
        public async Task GoToIdnesMainPageTest_ShouldPass()
        {
            await _cButtons.GoToIdnesMainPage();            
        }

        [Test]
        [Category("Cookies")]
        public async Task GoToCookiesSite()
        {
            await _cButtons.GoToIdnesMainPage();
            await _cButtons.GoToSetupCookies();
        }

        [Test]
        [Category("Cookies")]
        public async Task GoToInitialPageAcceptAllCookies()
        {
            await _cButtons.GoToIdnesMainPageAscceptAllCookies();            
        }

        [Test]
        [Category("Cookies")]
        public async Task DetailedCookiesSettingsButtonClick_ShouldPass()
        {
            await _cButtons.DetailedCookiesSettingsButtonClick();
        }

        [Test]
        [Category("Cookies")]
        public async Task UkladaniANeboPristupKInfVZarizeniClick_ShouldPass()
        {
            await _cButtons.UkladaniANeboPristupKInfVZarizeniNesouhlasitClick();
        }

        [Test]
        [Category("Cookies")]
        public async Task UkladaniANeboPristupKInfVZarizeniSouhlasitClick_ShouldPass()
        {
            await _cButtons.UkladaniANeboPristupKInfVZarizeniSouhlasitClick();
        }

        [Test]
        [Category("Cookies")]
        public async Task PersonalisovanaReklamaAObsahSouhlasit_ShouldPass()
        {
            await _cButtons.PersonalisovanaReklamaAObsahSouhlasit();
        }

        [Test]
        [Category("Cookies")]
        public async Task PersonalisovanaReklamaAObsahNesouhlasit_ShouldPass()
        {
            await _cButtons.PersonalisovanaReklamaAObsahNesouhlasit();
        }

        [Test]
        [Category("Cookies")]
        public async Task ZpracovaniUdajuVydavateliAPartnerySouhlasit_ShouldPass()
        {
            await _cButtons.ZpracovaniUdajuVydavateliAPartnerySouhlasit();
        }
    }
}
