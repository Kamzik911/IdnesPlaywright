using IdnesPlaywright.Setup;

namespace IdnesPlaywright.LoginPage
{
    public class LoginPageElements : ILoginPageElements
    {

        protected IUiActions _uiActions;
        protected LoginPageLocators _lpLocators;

        public LoginPageElements(IUiActions uiActions) 
        {
            _uiActions = uiActions;
            _lpLocators = new LoginPageLocators();
        }

        public async Task GoToUserLoginPage()
        {
            await _uiActions.GotoWebPageCheckExpectPage(_lpLocators.LoginUrl, _lpLocators.LoginUrl);
        }

        public async Task IdontHaveAccountYet()
        {
            _uiActions.FindLocatorByLink(_lpLocators.IdontHaveAccountButton);
        }

        public async Task FillEmail()
        {
            await _uiActions.FillElementAndCheckValue(_lpLocators.EmailLocator, _lpLocators.EmailTestAddress);
        }

        public async Task LoginPageContinueButton()
        {
            await _uiActions.FindLocatorAndClick(_lpLocators.UserLoginPokracovatButton);
        }

        public async Task LoginPageForgivenPasswordButton()
        {
            await _uiActions.FindLocatorByRoleButtonCheckVisible(_lpLocators.ForgivenPassword);
        }

        public async Task FastLoginText()
        {
            await _uiActions.CheckAriaHeadingVisibility(_lpLocators.FastLogin);
        }

        public async Task ChooseLoginText()
        {
            _uiActions.FindLocatorByExactTextString(_lpLocators.ChooseLoginLocator, _lpLocators.ChooseLoginText);
        }

        public async Task CheckLoginButtonVisibility(string loginButton)
        {
            await _uiActions.CheckAriaButtonVisibility(loginButton);
        }       

        public async Task QuickLoginButtonsVisibility()
        {
            var buttons = new[]
            {
                _lpLocators.GoogleQuickLoginButton,
                _lpLocators.FacebookQuickLoginButton,
                _lpLocators.AppleQuickLoginButton,
                _lpLocators.BankIdentityQuickLoginButton,
                _lpLocators.MyIDQuickLoginButton

            };

            foreach (string button in buttons)
            {
                await CheckLoginButtonVisibility(button);
            }
        }        
    }
}
