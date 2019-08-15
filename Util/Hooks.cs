using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;

namespace MyProject.Specs.Util
{
    [Binding]
    public sealed class Hooks
    {
        
       
        private static IWebDriver driver;

        private Hooks()
        {
            
        }

        [BeforeScenario]
        public void RodarAntesDoCenario()
        {

        }
 
        public static IWebDriver RetornarDriver(string url)
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            return driver;
        }

        // Reuse browser for the whole run.
        [AfterScenario]
        public static void AfterTestRun()
        {
            driver.Quit();
        }
    }
}

