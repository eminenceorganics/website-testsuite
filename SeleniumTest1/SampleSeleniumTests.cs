using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest1
{
    [TestClass]
    public class SampleSeleniumTests
    {
        /// <summary>
        /// Opens and closes a Chrome browser.
        /// </summary>
        [TestMethod]
        public void ChromeSession()
        {
            //Sets up Selenium.
            new DriverManager().SetUpDriver(new ChromeConfig());
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://eminenceorganics.com");

            //At the top of this test, after it runs you can 'right-click' on the test in the test explorer
            //and select "view log", or you can click the little green checkbox icon (or red icon) at the top
            //of this method.
            Thread.Sleep(2000); //wait 2 seconds
            
            driver.Quit(); //Closes the web browser (unless it fails)
        }

        /// <summary>
        /// Opens Chrome, searches for text, and closes Chrome.
        /// </summary>
        [TestMethod]
        public void SearchBasic()
        {
            //Sets up Selenium.
            new DriverManager().SetUpDriver(new ChromeConfig());
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://eminenceorganics.com");

            //Give the page a moment to catchup loading.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500); //.5 seconds

            //Search for blueberry
            //var searchBox = driver.FindElement(By.Id("edit-s"));  //Tip: Use "inspect to find a uniqe way to get an element.
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4)); //Max wait of 4 seconds
            //var searchBox = wait.Until(d => d.FindElement(By.Id("edit-s")));
            var searchBox = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("edit-s")));

            Thread.Sleep(1500); //wait 3.5 seconds just for demo puproses
            driver.Quit();
        }
    }
}
