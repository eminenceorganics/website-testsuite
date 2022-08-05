using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System;
using System.Threading;
using OpenQA.Selenium;

namespace SeleniumTest1
{
    [TestClass]
    public class SampleTesting
    {
        /// <summary>
        /// Demonstrates "Best Practices"
        /// </summary>
        [TestMethod]
        public void Basics101_AAA()
        {
            //AAA ==> Arrange, Act, Assert

            //STEP 1 - Arrange: initialize objects, set variable values
            var minimumWeightInLbs = 0.5;

            //STEP 2 - Act: run the code or browser actions.
            //Pretend some program returned this weight.
            var testResultsWeight = 123.0;

            //STEP 3 - Assert: Tests if the code function as it should.
            //It's ok to test that it failed.
            Assert.IsTrue(testResultsWeight >= minimumWeightInLbs);
        }

        /// <summary>
        /// Opens Chrome, searches for text, and closes Chrome.
        /// </summary>
        [TestMethod]
        public void Basics101_Failing()
        {
            //Arrange
            var expectedCustomerName = "Supreme Tester";

            //Act
            //pretent the name that came back was incorrect.
            var receivedCustName = "abc";

            //Assert (and for demo purposes this fail
            Assert.IsTrue(expectedCustomerName.Equals(receivedCustName),
                $"Received value \"{receivedCustName}\" id not equal expected value \"{expectedCustomerName}\".");
                
        }
    }
}
