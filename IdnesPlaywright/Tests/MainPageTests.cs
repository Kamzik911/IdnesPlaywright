using IdnesPlaywright.MainPage;
using IdnesPlaywright.Setup;

namespace IdnesPlaywright.Tests
{
    public class MainPageTests : BaseTest
    {           
        protected IMainPageElementActions _mpElementActions;
        protected IMainPageButtons _mpButtons;        
        
        [SetUp]
        public void SetupPageObjects()
        {
            _mpElementActions = new MainPageElementActions(Page);
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
        public async Task AcceptAllCookies()
        {
            await _mpButtons.GoToIdnesMainPageAscceptAllCookies();            
        }
    }
}
