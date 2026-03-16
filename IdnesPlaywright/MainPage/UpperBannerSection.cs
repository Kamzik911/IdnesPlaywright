using IdnesPlaywright.Setup;
using Microsoft.Playwright;
using System.Diagnostics;

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
            var locator = item switch
            {
                UpperBannerItems.Zpravy => _mpLocators.ZpravyButton,
                UpperBannerItems.Kraje => _mpLocators.KrajeButton,
                UpperBannerItems.Sport => _mpLocators.SportButton,
                UpperBannerItems.Magaziny => _mpLocators.MagazinyButton,
                UpperBannerItems.Revue => _mpLocators.RevueButton,
                UpperBannerItems.Video => _mpLocators.VideoButton,
                UpperBannerItems.Premium => _mpLocators.PremiumButton,
                UpperBannerItems.Spotrebitel => _mpLocators.SportButton,
                UpperBannerItems.Zabava => _mpLocators.ZabavaButton,
                UpperBannerItems.Expres => _mpLocators.ExpresButton,
            };

            await _mpElementActions.CheckLocatorVisibility(locator);
        }
    }
}
