using FluentAssertions;
using FluentAssertions.Execution;
using SampleProjectSpecflowActionsSeleniumBrowserStack.PageObjects;
using SpecFlow.Actions.Selenium;
using TechTalk.SpecFlow;

namespace SampleProjectSpecflowActionsSeleniumBrowserStack.Steps
{
    [Binding]
    public sealed class MainPageStepDefinition
    {
        // private readonly BrowserDriver _browserDriver;
        private readonly MainPage _mainPage;

        /*public MainPageStepDefinition(BrowserDriver browserDriver)
        {
            _browserDriver = browserDriver;
        }*/

        public MainPageStepDefinition(MainPage mainPage)
        {
            _mainPage = mainPage;
        }

        [Given(@"I navigated to Amazon using")]
        public void GivenINavigatedToAmazonUsing()
        {
            _mainPage.GoTo();
            //_browserDriver.Current.Manage().Window.Maximize();
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