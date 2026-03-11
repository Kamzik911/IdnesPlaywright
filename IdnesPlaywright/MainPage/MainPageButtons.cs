using IdnesPlaywright.Setup;

namespace IdnesPlaywright.MainPage
{
    public class MainPageButtons : IMainPageButtons
    {
        readonly IElementActions _mPElementActions;
        readonly MainPageLocators _mpLocators;

        public MainPageButtons(IElementActions mPElementActions) 
        {
            _mPElementActions = mPElementActions;
            _mpLocators = new MainPageLocators();
        }

        public async Task GoToIdnesMainPage()
        {
            await _mPElementActions.GoToWebPage(_mpLocators.InitialPageIdnes);            
        }

        public async Task GoToSetupCookies()
        {
            await _mPElementActions.GetLocatorByLinkRoleAndClick(_mpLocators.CookieSettingsPage);
        }

        public async Task GoToIdnesMainPageAscceptAllCookies()
        {
            await GoToIdnesMainPage();
            await _mPElementActions.GetLocatorByLinkRoleAndClick(_mpLocators.CookieSettingsPage);
            await _mPElementActions.GetLocatorByLinkRoleAndClick(_mpLocators.AcceptAllCookiesButton);
        }       

        //Buttons
        public async Task UpperBannerZpravyButton()        {
            
            await _mPElementActions.GetLocatorCheckVisibility(_mpLocators.ZpravyButton);
        }

        public async Task UpperBannerKrajeButton()
        {
            await _mPElementActions.GetLocatorCheckVisibility(_mpLocators.KrajeButton);
        }

        public async Task UpperBannerSportButton()
        {
            await _mPElementActions.GetLocatorCheckVisibility(_mpLocators.SportButton);
        }
    }
}
