namespace IdnesPlaywright.MainPage
{
    public interface IUpperBannerSection
    {
        Task CheckUpperBannerButtonVisible(UpperBannerItems item);
        Task UpperBannerZpravyButtonVisible();
        Task UpperBannerKrajeButtonVisible();
        Task UpperBannerSportButtonVisible();
        Task UpperBannerMagazinyButtonVisible();
        Task UpperBannerRevueButtonVisible();
        Task UpperBannerVideoButtonVisible();
        Task UpperBannerPremiumButtonVisible();
        Task UpperBannerSpotrebitelButtonVisible();
        Task UpperBannerZabavaButtonVisible();
        Task UpperBannerExpresButtonVisible();
    }
}
