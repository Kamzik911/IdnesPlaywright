namespace IdnesPlaywright.LoginPage
{
    public interface ILoginPageElements
    {
        Task GoToUserLoginPage();
        Task IdontHaveAccountYet();
        Task FillEmail();
        Task LoginPageContinueButton();
        Task LoginPageForgivenPasswordButton();
        Task FastLoginText();
        Task ChooseLoginText();
        Task CheckLoginButtonVisibility(string buttonName);
        Task QuickLoginButtonsVisibility();        
    }
}
