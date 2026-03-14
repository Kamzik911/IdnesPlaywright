using IdnesPlaywright.Setup;

namespace IdnesPlaywright.MainPage
{
    public class MainPageButtons : IMainPageButtons
    {
        readonly IElementActions _mpElementActions;
        readonly MainPageLocators _mpLocators;

        public MainPageButtons(IElementActions mPElementActions) 
        {
            _mpElementActions = mPElementActions;
            _mpLocators = new MainPageLocators();
        }

        public async Task GoToIdnesMainPage()
        {
            await _mpElementActions.GoToWebPage(_mpLocators.InitialPageIdnes);            
        }

        public async Task GoToSetupCookies()
        {
            await _mpElementActions.GetLocatorByLinkRoleAndClick(_mpLocators.CookieSettingsPage);
        }

        public async Task GoToIdnesMainPageAscceptAllCookies()
        {
            await GoToIdnesMainPage();
            await _mpElementActions.GetLocatorByLinkRoleAndClick(_mpLocators.CookieSettingsPage);
            await _mpElementActions.GetLocatorByLinkRoleAndClick(_mpLocators.AcceptAllCookiesButton);
        }        
    }
}
