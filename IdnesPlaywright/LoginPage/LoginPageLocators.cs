namespace IdnesPlaywright.LoginPage
{
    public class LoginPageLocators
    {
        public string LoginUrl = "https://ucet.idnes.cz/prihlasit";

        //Elements
        public string EmailLocator = "input[name='email']";
        public string EmailTestAddress = "test@test.cz";
        public string UserLoginPokracovatButton = "input[value='Pokračovat']";
        public string ForgivenPassword = "Zapomenuté heslo";
        public string FastLogin = "Rychlé přihlášení";
        public string ChooseLoginLocator = ".sso-soc-intro";
        public string ChooseLoginText = "Využitím této volby vytvoříte Účet iDNES, který využijete pro budoucí přihlašování.";
    }
}
