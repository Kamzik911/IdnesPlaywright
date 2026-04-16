using IdnesPlaywright.MainPage;
using IdnesPlaywright.MainPageMainMenu;
using IdnesPlaywright.Setup;

namespace IdnesPlaywright.Tests.MainPage
{
    public class MainPageMainMenuTests : BaseTest
    {
        protected MainMenuLocators _mMLocators;
        protected IMainMenuElements _mainMenuElements;
        protected ICookiesButtons _cookiesButtons;
        protected UiActions _uiActions;

        [SetUp]
        public void SetupMainMenuTests()
        {
            _uiActions = new UiActions(Page);            
            _mainMenuElements = new MainMenuElements(_uiActions);
            _cookiesButtons = new CookiesButtons(_uiActions);
            _mMLocators = new MainMenuLocators();
            _cookiesButtons.GoToIdnesMainPage();
        }

        [Test]
        [Category("Regression")]
        public async Task MainMenuButtonClick()
        {
            await _mainMenuElements.MainMenuButtonClick();             
        }

        [Test]
        [Category("Regression")]
        public async Task MainMenuMainMenuSectionButtonsVisibility_ShoultPass()
        {
            await _mainMenuElements.MainMenuButtonClick();
            await _mainMenuElements.MainMenuSectionButtonsVisibility();
        }
    }
}
