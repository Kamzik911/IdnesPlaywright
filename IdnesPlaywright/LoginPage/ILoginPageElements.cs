namespace IdnesPlaywright.LoginPage
{
    public interface ILoginPageElements
    {
        Task GoToUserLoginPage();
        Task FillEmail();
        Task LoginPageContinueButton();
        Task LoginPageForgivenPasswordButton();
        Task FastLoginText();
        Task ChooseLoginText();
    }
}
