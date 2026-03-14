using IdnesPlaywright.Setup;

namespace IdnesPlaywright.MainPage
{
    public class CookiesButtons : ICookiesButtons
    {
        readonly IElementActions _mpElementActions;
        readonly MainPageLocators _mpLocators;

        public CookiesButtons(IElementActions mPElementActions) 
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

        public async Task GoToDetailedCookiesSettings()
        {
            await GoToIdnesMainPage();
            await GoToSetupCookies();
        }

        public async Task DetailedCookiesSettingsButtonClick()
        {
            await GoToDetailedCookiesSettings();
            await _mpElementActions.FindLocatorAndClick(_mpLocators.DetailedSettingsButton);
        }        
    }
}
