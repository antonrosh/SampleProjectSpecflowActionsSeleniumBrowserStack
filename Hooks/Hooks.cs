using SpecFlow.Actions.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SampleProjectSpecflowActionsSeleniumBrowserStack.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly BrowserDriver _browserDriver;

        public Hooks(BrowserDriver browserDriver)
        {
            _browserDriver = browserDriver;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _browserDriver.Current.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
        }
    }
}