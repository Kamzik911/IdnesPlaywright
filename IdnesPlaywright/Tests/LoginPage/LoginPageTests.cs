using IdnesPlaywright.LoginPage;
using IdnesPlaywright.Setup;

namespace IdnesPlaywright.Tests.LoginPage
{
    public class LoginPageTests : BaseTest
    {
        protected IUiActions _uiActions;
        protected ILoginPageButtons _loginPageButtons;

        [SetUp]
        public async Task SetupUserLoginTests()
        {
            _uiActions = new UiActions(Page);
            _loginPageButtons = new LoginPageButtons(_uiActions);
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
    }
}
