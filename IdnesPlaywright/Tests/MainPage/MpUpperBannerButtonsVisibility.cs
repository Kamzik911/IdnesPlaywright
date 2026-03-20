using IdnesPlaywright.MainPage;
using IdnesPlaywright.Setup;

namespace IdnesPlaywright.Tests.MainPage
{
    public class MpUpperBannerButtonsVisibility : BaseTest
    {
        protected IUiActions _mpElementActions;
        protected ICookiesButtons _cButtons;
        protected IUpperBannerSection _mpBannerSection;
        

        [SetUp]
        public void SetupPageObjects()
        {
            _mpElementActions = new UiActions(Page);
            _cButtons = new CookiesButtons(_mpElementActions);
            _mpBannerSection = new UpperBannerSection(_mpElementActions);            
        }

        //Visibility tests
        [TestCase(UpperBannerItems.Zpravy)]
        [TestCase(UpperBannerItems.Kraje)]
        [TestCase(UpperBannerItems.Sport)]
        [TestCase(UpperBannerItems.Magaziny)]
        [TestCase(UpperBannerItems.Revue)]
        [TestCase(UpperBannerItems.Video)]
        [TestCase(UpperBannerItems.Premium)]
        [TestCase(UpperBannerItems.Spotrebitel)]
        [TestCase(UpperBannerItems.Zabava)]
        [TestCase(UpperBannerItems.Expres)]
        [Category("Regression")]
        public async Task UpperBannerButton_ShouldBeVisible(UpperBannerItems item)
        {
            await _cButtons.GoToIdnesMainPageAscceptAllCookies();
            await _mpBannerSection.CheckUpperBannerButtonVisible(item);
        }        
    }
}
