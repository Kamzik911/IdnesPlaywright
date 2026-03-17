using IdnesPlaywright.MainPage;
using IdnesPlaywright.Setup;

namespace IdnesPlaywright.Tests.MainPage
{
    public class UserLogin : BaseTest
    {
        protected MainPageLocators _mpLocators;
        protected ICookiesButtons _cButtons;
        protected IUserLoginButtons _userLoginButtons;
        protected IUiActions _uiActions;

        [SetUp]
        public void SetupUserLogin()
        {            
            _uiActions = new UiActions(Page);
            _cButtons = new CookiesButtons(_uiActions);
            _mpLocators = new MainPageLocators();
            _userLoginButtons = new UserLoginButtons(_uiActions, _mpLocators);
        }

        [Test]
        public async Task UserLoginButton() 
        {
            await _cButtons.GoToIdnesMainPage();
            await _userLoginButtons.UserLoginButtonClick();
        }
    }
}
