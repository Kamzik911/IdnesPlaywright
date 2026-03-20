using IdnesPlaywright.Setup;

namespace IdnesPlaywright.LoginPage
{
    public class LoginPageButtons : ILoginPageButtons
    {

        protected IUiActions _uiActions;
        protected LoginPageLocators _lpLocators;

        public LoginPageButtons(IUiActions uiActions) 
        {
            _uiActions = uiActions;
            _lpLocators = new LoginPageLocators();
        }

        public async Task GoToUserLoginPage()
        {
            await _uiActions.GotoWebPageCheckExpectPage(_lpLocators.LoginUrl, _lpLocators.LoginUrl);
        }

        public async Task FillEmail()
        {
            await _uiActions.FillElementAndCheckValue(_lpLocators.EmailLocator, _lpLocators.EmailTestAddress);
        }
    }
}
