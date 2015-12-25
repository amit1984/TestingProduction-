using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Production.selenium;

namespace UnitTestProduction
{
    [TestClass]
    public class LoginTest
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            this.Driver = new FirefoxDriver();
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
        }

        [TestCleanup]
        public void TeardownTest()
        {
            this.Driver.Quit();
        }

        [TestMethod]
        public void SearchTextInBing_First()
        {
            LoginPage bingMainPage = new LoginPage(this.Driver);
            bingMainPage.Navigate();
            bingMainPage.Search("Automate The Planet");
            bingMainPage.ValidateResultsCount("264,000 RESULTS");
        }
    }
}
