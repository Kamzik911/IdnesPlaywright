using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;

namespace IdnesPlaywright.Setup
{
    public class UiActions : IUiActions
    {
        private readonly IPage _page;
        public UiActions(IPage page)
        {
            _page = page;
        }

        public async Task GoToWebPage(string url)
        {
            await _page.GotoAsync(url, new()
            {
                WaitUntil = WaitUntilState.DOMContentLoaded,
                Timeout = 60000
            });
        }

        public async Task GotoWebPageCheckExpectPage(string url, string expectedUrl)
        {
            await GoToWebPage(url);
            await Expect(_page).ToHaveURLAsync(new Regex(expectedUrl));
        }

        public ILocator FindLocator(string selectLocator)
        {
            return _page.Locator(selectLocator);
        }

        public async Task FillElement(string selectLocator, string textToElement)
        {
            var locator = FindLocator(selectLocator);
            await locator.FillAsync(textToElement);
        }

        public async Task FillElementAndCheckValue(string selectLocator, string textToElement)
        {
            await FillElement(selectLocator, textToElement);
            var locator = FindLocator(selectLocator);
            await Expect(locator).ToHaveValueAsync(textToElement);
        }

        public ILocator FindLocatorByTextString(string selectLocator, string textString)
        {
            return _page.Locator(selectLocator).Filter(new() { HasTextString = textString });
        }

        public ILocator FindLocatorByExactTextString(string selectLocator, string textString)
        {
            return _page.Locator(selectLocator).Filter(new()
            {
                HasTextRegex = new Regex($"^{Regex.Escape(textString)}$")
            });
        }

        public async Task<int> FindLocatorCount(ILocator locator)
        {
            return await locator.CountAsync();
        }

        public ILocator FindLocatorByLink(string selectLocator)
        {
            return _page.GetByRole(AriaRole.Link, new() { Name = selectLocator, Exact = false });
        }

        public ILocator FindLocatorByRadio(string selectLocator)
        {
            return _page.GetByRole(AriaRole.Radio, new() { Name = selectLocator });
        }

        public ILocator FindLocatorByButton(string selectLocator)
        {
            return _page.GetByRole(AriaRole.Button, new() { Name = selectLocator });
        }

        public ILocator FindLocatorByHeading(string selectLocator)
        {
            return _page.GetByRole(AriaRole.Heading, new() { Name = selectLocator });
        }

        public async Task CheckLocatorVisibility(string selectLocator)
        {
            var element = FindLocator(selectLocator);
            await Expect(element).ToBeVisibleAsync();
        }

        public async Task CheckAriaHeadingVisibility(string selectLocator)
        {
            var element = FindLocatorByHeading(selectLocator);
            await Expect(element).ToBeVisibleAsync();
        }

        public async Task CheckAriaLinkVisibility(string selectLocator)
        {
            var element = FindLocatorByLink(selectLocator);
            await Expect(element).ToBeVisibleAsync();
        }

        public async Task CheckAriaButtonVisibility(string selectLocator)
        {
            var element = FindLocatorByButton(selectLocator);
            await Expect(element).ToBeVisibleAsync();
        }

        public async Task FindLocatorAndClick(string selectLocator)
        {
            var element = FindLocator(selectLocator);
            var count = await element.CountAsync();
            Console.WriteLine($"Počet nalezených elementů: {count}");
            await element.ClickAsync();
        }

        public async Task FindLocatorByLinkRoleAndClick(string selectLocator)
        {
            var element = FindLocatorByLink(selectLocator);
            await element.ClickAsync();
        }

        public async Task FindLocatorByTextStringClick(string selectLocator, string textString)
        {
            var element = FindLocatorByTextString(selectLocator, textString);
            await element.ClickAsync();
        }

        public async Task FindLocatorByExactTextStringClick(string selectLocator, string textString)
        {
            var element = FindLocatorByExactTextString(selectLocator, textString);
            await element.ClickAsync();
        }

        public async Task FindLocatorByRoleButtonCheckVisible(string selectLocator)
        {
            var buttonLocator = FindLocatorByButton(selectLocator);
            await Expect(buttonLocator).ToBeVisibleAsync();
        }

        //Mouse right click
        public async Task RightClickOnElement(string selectLocator)
        {
            var element = FindLocator(selectLocator);
            await element.ClickAsync(new() { Button = MouseButton.Right });
        }

        //Mouse movements
        public async Task MoveMouseToElement(string selectLocator)
        {
            await FindLocator(selectLocator).HoverAsync();
        }

        public async Task MoveSliderByMouse(string selectLocator)
        {
            var slider = FindLocator(selectLocator);
            var boundingBox = await slider.BoundingBoxAsync();

            //Calculate the center of the slider
            float startX = boundingBox.X + boundingBox.Width / 2;
            float startY = boundingBox.Y + boundingBox.Height / 2;

            //Move the mouse to the center of the slider
            float targetX = startX + 50; // Move 50 pixels to the right
            float targetY = startY;
            await _page.Mouse.MoveAsync(startX, startY);

            // Click and hold the mouse button, then move to the target position
            await _page.Mouse.DownAsync();

            // move to a point 50 pixels to the right of the slider's center
            await _page.Mouse.MoveAsync(targetX, targetY, new() { Steps = 10 });

            // release the mouse button after moving to the target position
            await _page.Mouse.UpAsync();
        }

        //Handle alerts
        public async Task HandleAlertClick(string selectLocator)
        {
            _page.Dialog += async (_, dialog) =>
            {
                Console.WriteLine($"Dialog message: {dialog.Message}");
                await dialog.AcceptAsync();
            };
            await FindLocator(selectLocator).ClickAsync();
        }

        //Handle frames
        public async Task HandleFrameClick(string frameName, string selectLocator)
        {
            var frame = _page.Frame(frameName);
            if (frame == null)
            {
                Console.WriteLine($"Frame with name '{frameName}' not found.");
                return;
            }
            await FindLocator(selectLocator).ClickAsync();
        }

        //Handle new tab or popup
        public async Task HandleNewTabClick(string selectLocator)
        {
            var newPageTask = await _page.RunAndWaitForPopupAsync(async () =>
            {
                await FindLocator(selectLocator).Nth(0).ClickAsync();
            });

            await newPageTask.WaitForLoadStateAsync();
        }

        //Execute JavaScript
        public async Task ExecuteJavaScript(string script)
        {
            await _page.EvaluateAsync(script);
        }
    }
}
