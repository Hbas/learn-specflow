using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Coypu;
using Coypu.Drivers;
using TechTalk.SpecFlow;

namespace Hbas.LearnSpecflow.IntegrationTests.Steps
{
    [Binding]
    public class AbstractStep : TechTalk.SpecFlow.Steps
    {
        [BeforeScenario]
        public static void CriarBrowser()
        {
            var browser = new BrowserSession(new SessionConfiguration()
            {
                AppHost = "unused",
                ConsiderInvisibleElements = false,
                Browser = Browser.Chrome
            });
            ScenarioContext.Current["browser"] = browser;
        }

        [AfterScenario]
        public static void FecharBrowser()
        {
            CurrentBrowser.Dispose();
        }

        public static BrowserSession CurrentBrowser
        {
            get
            {
               return (BrowserSession) ScenarioContext.Current["browser"];
            }
        }
    }
}
