using IdnesPlaywright.Setup;

namespace IdnesPlaywright.MainPage
{
    public class UserLoginButtons : IUserLoginButtons
    {
        protected IUiActions _uiActions;
        protected MainPageLocators _mpLocators;

        public UserLoginButtons(IUiActions uiActions, MainPageLocators mpLocators) 
        {
            _uiActions = uiActions;
            _mpLocators = mpLocators;
        }

        public async Task UserLoginButtonClick()
        {
            await _uiActions.FindLocatorAndClick(_mpLocators.UserLoginButton);
        }        

        public async Task PrihlasitButtonVisibility()
        {
            await _uiActions.CheckLocatorVisibility(_mpLocators.UserLoginButton);
        }

        public async Task PrihlasitButtonClick()
        {
            await _uiActions.FindLocatorAndClick(_mpLocators.UserLoginButton);            
        }
    }
}
