using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SaucyProject1.Hooks
{
    [Binding]
    public class WebHooks
    {
        public static IWebDriver driver;

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

        }

        //[BeforeScenario(Order = 1)]
        //public void FirstBeforeScenario()
        //{
        //    // Example of ordering the execution of hooks
        //    // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

        //    //TODO: implement logic that has to run before executing each scenario
        //}

        [AfterScenario]
        public static void AfterScenario()
        {
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
            driver.Dispose();
          
        }
    }
}