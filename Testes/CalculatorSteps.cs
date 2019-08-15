using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using MyProject.Specs.Paginas;
using MyProject.Specs.Util;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace MyProject.Specs
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly ElementosDaPagina _elementosDaPagina;

        public CalculatorSteps()

        {
            _elementosDaPagina = new ElementosDaPagina(Hooks.RetornarDriver(Config.url));
        }

        
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int pO)
        {
           

        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            
        }
    }
}
