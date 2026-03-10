namespace IdnesPlaywright.MainPage
{
    public class MainPageButtons : IMainPageButtons
    {
        readonly IMainPageElementActions _mPElementActions;
        readonly MainPageLocators _mpLocators;

        public MainPageButtons(IMainPageElementActions mPElementActions) 
        {
            _mPElementActions = mPElementActions;
            _mpLocators = new MainPageLocators();
        }

        public async Task GoToIdnesMainPage()
        {
            await _mPElementActions.GoToWebPage(_mpLocators.MainPageIdnes);            
        }

        public async Task GoToSetupCookies()
        {
            await _mPElementActions.GetLocatorByLinkRoleAndClick(_mpLocators.CookieSettingsPage);
        }
    }
}
