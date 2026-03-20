namespace IdnesPlaywright.LoginPage
{
    public interface ILoginPageButtons
    {
        Task GoToUserLoginPage();
        Task FillEmail();
        Task LoginPageContinueButton();
    }
}
