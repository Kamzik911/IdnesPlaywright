using IdnesPlaywright.Setup;

namespace IdnesPlaywright.MainPage
{
    public class UpperBannerButtons : IMainPageBannerButtons
    {
        readonly IElementActions _mpElementActions;
        readonly MainPageLocators _mpLocators;

        public UpperBannerButtons(ElementActions elementActions, MainPageLocators mpLocators)
        {
            _mpElementActions = elementActions;
            _mpLocators = mpLocators;
        }

        public async Task UpperBannerZpravyButton()
        {

            await _mpElementActions.CheckLocatorVisibility(_mpLocators.ZpravyButton);
        }

        public async Task UpperBannerKrajeButton()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.KrajeButton);
        }

        public async Task UpperBannerSportButton()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.SportButton);
        }

        public async Task UpperBannerMagazinyButton()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.MagazinyButton);
        }

        public async Task UpperBannerRevueButton()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.RevueButton);
        }

        public async Task UpperBannerVideoButton()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.VideoButton);
        }

        public async Task UpperBannerPremiumButton()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.PremiumButton);
        }

        public async Task UpperBannerSpotrebitelButton()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.PremiumButton);
        }

        public async Task UpperBannerZabavaButton()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.ZabavaButton);
        }

        public async Task UpperBannerExpresButton()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.ExpresButton);
        }
    }
}
