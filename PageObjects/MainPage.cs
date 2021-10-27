using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;

namespace SampleProjectSpecflowActionsSeleniumBrowserStack.PageObjects
{
    public class MainPage
    {
        private readonly IBrowserInteractions _browserInteractions;

        public MainPage(IBrowserInteractions browserInteractions)
        {
            _browserInteractions = browserInteractions;
        }

        #region
        private static string PageUrl => "https://www.amazon.com/";
        private IWebElement AmazonLogo => _browserInteractions.WaitAndReturnElement(By.XPath("//a[@id='nav-logo-sprites']"));
        #endregion

        #region

        public void GoTo()
        {
            _browserInteractions.GoToUrl(PageUrl);
        }

        public bool IsAmazonLogoExist()
        {
            return AmazonLogo.Displayed;
        }

        #endregion
    }
}