using IdnesPlaywright.Setup;

namespace IdnesPlaywright.MainPage
{
    public class CookiesButtons : ICookiesButtons
    {
        readonly IUiActions _mpElementActions;
        readonly MainPageLocators _mpLocators;

        public CookiesButtons(IUiActions mPElementActions) 
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
        
        public async Task UkladaniANeboPristupKInfVZarizeniSouhlasitClick()
        {
            await DetailedCookiesSettingsButtonClick();
            await _mpElementActions.GetFindLocatorByExactTextStringClick(_mpLocators.UkladaniANeboPristupKInfVZarizeni, _mpLocators.Souhlasit);
        }

        public async Task UkladaniANeboPristupKInfVZarizeniNesouhlasitClick()
        {
            await DetailedCookiesSettingsButtonClick();
            await _mpElementActions.GetFindLocatorByExactTextStringClick(_mpLocators.UkladaniANeboPristupKInfVZarizeni, _mpLocators.Nesouhlasit);
        }        

        public async Task PersonalisovanaReklamaAObsahSouhlasit()
        {
            await DetailedCookiesSettingsButtonClick();
            await _mpElementActions.GetFindLocatorByExactTextStringClick(_mpLocators.PersonalisovanaReklamaAObsah, _mpLocators.Souhlasit);
        }

        public async Task PersonalisovanaReklamaAObsahNesouhlasit()
        {
            await DetailedCookiesSettingsButtonClick();
            await _mpElementActions.GetFindLocatorByExactTextStringClick(_mpLocators.PersonalisovanaReklamaAObsah, _mpLocators.Nesouhlasit);
        }

        public async Task ZpracovaniUdajuVydavateliAPartnerySouhlasit()
        {
            await DetailedCookiesSettingsButtonClick();
            await _mpElementActions.GetFindLocatorByExactTextStringClick(_mpLocators.ZpracovaniUdajuVydavateliAPartnery, _mpLocators.Souhlasit);
        }
    }
}
