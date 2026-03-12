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

        //Upper banner buttons
        public async Task UpperBannerZpravyButton()        {
            
            await _mpElementActions.GetLocatorCheckVisibility(_mpLocators.ZpravyButton);
        }

        public async Task UpperBannerKrajeButton()
        {
            await _mpElementActions.GetLocatorCheckVisibility(_mpLocators.KrajeButton);
        }

        public async Task UpperBannerSportButton()
        {
            await _mpElementActions.GetLocatorCheckVisibility(_mpLocators.SportButton);
        }

        public async Task UpperBannerMagazinyButton()
        {
            await _mpElementActions.GetLocatorCheckVisibility(_mpLocators.MagazinyButton);
        }

        public async Task UpperBannerRevueButton()
        {
            await _mpElementActions.GetLocatorCheckVisibility(_mpLocators.RevueButton);
        }

        public async Task UpperBannerVideoButton()
        {
            await _mpElementActions.GetLocatorCheckVisibility(_mpLocators.VideoButton);
        }

        public async Task UpperBannerPremiumButton()
        {
            await _mpElementActions.GetLocatorCheckVisibility(_mpLocators.PremiumButton);
        }

        public async Task UpperBannerSpotrebitelButton()
        {
            await _mpElementActions.GetLocatorCheckVisibility(_mpLocators.PremiumButton);
        }
    }
}
