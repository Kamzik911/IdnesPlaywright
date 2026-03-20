using IdnesPlaywright.LoginPage;
using IdnesPlaywright.Setup;

namespace IdnesPlaywright.Tests.LoginPage
{
    public class LoginPageTests : BaseTest
    {
        protected IUiActions _uiActions;
        protected ILoginPageButtons _loginPageButtons;

        [SetUp]
        public void SetupUserLoginTests()
        {
            _uiActions = new UiActions(Page);
            _loginPageButtons = new LoginPageButtons(_uiActions);
        }

        [Test]
        [Category("Regression")]
        public async Task LoginPageFillEmail()
        {
            await _loginPageButtons.GoToUserLoginPage();
            await _loginPageButtons.FillEmail();
        }
    }
}
