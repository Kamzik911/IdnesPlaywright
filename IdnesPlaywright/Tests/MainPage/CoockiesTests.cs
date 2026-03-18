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

        [Test]
        public async Task UkladaniANeboPristupKInfVZarizeniClick_ShouldPass()
        {
            await _cButtons.UkladaniANeboPristupKInfVZarizeniNesouhlasitClick();
        }

        [Test]
        public async Task UkladaniANeboPristupKInfVZarizeniSouhlasitClick_ShouldPass()
        {
            await _cButtons.UkladaniANeboPristupKInfVZarizeniSouhlasitClick();
        }

        [Test]
        public async Task PersonalisovanaReklamaAObsahSouhlasit_ShouldPass()
        {
            await _cButtons.PersonalisovanaReklamaAObsahSouhlasit();
        }

        [Test]
        public async Task PersonalisovanaReklamaAObsahNesouhlasit_ShouldPass()
        {
            await _cButtons.PersonalisovanaReklamaAObsahNesouhlasit();
        }

        [Test]
        public async Task ZpracovaniUdajuVydavateliAPartnerySouhlasit_ShouldPass()
        {
            await _cButtons.ZpracovaniUdajuVydavateliAPartnerySouhlasit();
        }
    }
}
