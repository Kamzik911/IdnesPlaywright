using IdnesPlaywright.Setup;

namespace IdnesPlaywright.MainPage
{
    public class UpperBannerSection : IUpperBannerSection
    {
        readonly IUiActions _mpElementActions;
        readonly MainPageLocators _mpLocators;

        public UpperBannerSection(IUiActions elementActions)
        {
            _mpElementActions = elementActions;
            _mpLocators = new MainPageLocators();
        }

        public async Task CheckUpperBannerButtonVisible(UpperBannerItems item)
        {
            await _mpElementActions.CheckLocatorVisibility(item);
        }

        public async Task UpperBannerZpravyButtonVisible()
        {

            await _mpElementActions.CheckLocatorVisibility(_mpLocators.ZpravyButton);
        }

        public async Task UpperBannerKrajeButtonVisible()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.KrajeButton);
        }

        public async Task UpperBannerSportButtonVisible()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.SportButton);
        }

        public async Task UpperBannerMagazinyButtonVisible()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.MagazinyButton);
        }

        public async Task UpperBannerRevueButtonVisible()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.RevueButton);
        }

        public async Task UpperBannerVideoButtonVisible()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.VideoButton);
        }

        public async Task UpperBannerPremiumButtonVisible()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.PremiumButton);
        }

        public async Task UpperBannerSpotrebitelButtonVisible()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.PremiumButton);
        }

        public async Task UpperBannerZabavaButtonVisible()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.ZabavaButton);
        }

        public async Task UpperBannerExpresButtonVisible()
        {
            await _mpElementActions.CheckLocatorVisibility(_mpLocators.ExpresButton);
        }
    }
}
