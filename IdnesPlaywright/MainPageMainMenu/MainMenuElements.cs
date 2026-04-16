using IdnesPlaywright.Setup;

namespace IdnesPlaywright.MainPageMainMenu
{
    public class MainMenuElements : IMainMenuElements
    {
        protected IUiActions _uiActions;
        protected MainMenuLocators _mMLocators;

        public MainMenuElements(IUiActions uiActions) 
        {
            _uiActions = uiActions;
            _mMLocators = new MainMenuLocators();
        }

        public async Task MainMenuButtonClick()
        {
            await _uiActions.CheckLocatorVisibility(_mMLocators.MainMenuButtonLocator);
            await _uiActions.FindLocatorAndClick(_mMLocators.MainMenuButtonLocator);
        }

        public async Task MainMenuSectionButtonsVisibility()
        {
            var buttons = new[]
            {
                _mMLocators.MainMenuNewsSectionButton,
                _mMLocators.MAinMenuKrajeSectionButton,
                _mMLocators.MainMenuSportSectionButton,
                _mMLocators.MainMenuMagazinesSectionButton,
                _mMLocators.MainMenuVideoSectionButton,
                _mMLocators.MainMenuPremiumSectionButton,
                _mMLocators.MainMenuExpresSectionButton,
                _mMLocators.MainMenuServicesSectionButton
            };
            foreach (string button in buttons)
            {
                await _uiActions.CheckAriaButtonVisibility(button);
            }
              
        }
    }
}
