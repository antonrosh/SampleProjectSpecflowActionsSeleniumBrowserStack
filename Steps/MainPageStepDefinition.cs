using FluentAssertions;
using FluentAssertions.Execution;
using SampleProjectSpecflowActionsSeleniumBrowserStack.PageObjects;
using TechTalk.SpecFlow;

namespace SampleProjectSpecflowActionsSeleniumBrowserStack.Steps
{
    [Binding]
    public sealed class MainPageStepDefinition
    {
        private readonly MainPage _mainPage;

        public MainPageStepDefinition(MainPage mainPage)
        {
            _mainPage = mainPage;
        }

        [Given(@"I navigated to Amazon using")]
        public void GivenINavigatedToAmazonUsing()
        {
            _mainPage.GoTo();
        }

        [Then(@"I should see Main Page")]
        public void ThenIShouldSeeMainPage()
        {
            using (new AssertionScope())
            {
                _mainPage.IsAmazonLogoExist().Should().Be(true);
            }
        }
    }
}