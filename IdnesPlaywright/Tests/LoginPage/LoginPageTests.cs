using IdnesPlaywright.LoginPage;
using IdnesPlaywright.Setup;

namespace IdnesPlaywright.Tests.LoginPage
{
    public class LoginPageTests : BaseTest
    {
        protected IUiActions _uiActions;
        protected ILoginPageElements _loginPageButtons;
        protected LoginPageLocators _lpLocators = new LoginPageLocators();

        [SetUp]
        public async Task SetupUserLoginTests()
        {
            _uiActions = new UiActions(Page);
            _loginPageButtons = new LoginPageElements(_uiActions);
            await _loginPageButtons.GoToUserLoginPage();
        }

        [Test]
        [Category("Regression")]
        public async Task LoginPageFillEmail()
        {            
            await _loginPageButtons.FillEmail();
        }

        [Test]
        [Category("Regression")]
        public async Task ClickOnContinueButton()
        {            
            await _loginPageButtons.LoginPageContinueButton();
        }

        [Test]
        [Category("Regression")]
        public async Task LoginPageForgivenPasswordButton_ShouldPass()
        {
            await _loginPageButtons.LoginPageForgivenPasswordButton();
        }

        [Test]
        [Category("Regression")]
        public async Task LoginPageFastLoginTextVisibility_ShouldPass()
        {
            await _loginPageButtons.FastLoginText();
        }

        [Test]
        [Category("Regression")]
        public async Task LoginPageChooseLoginTextVisibility_ShouldPass()
        {
            await _loginPageButtons.ChooseLoginText();
        }

        [Test]
        [Category("Regression")]
        public async Task QuickLoginButtonsVisibility_ShouldPass()
        {
            await _loginPageButtons.QuickLoginButtonsVisibility();
        }
    }
}
