using System;
using System.Text;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace First_Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ToolsQAExercise1
    {
        public void ToolsQA()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Exercise1()
        {
            //
            // TODO: Add test logic here
            //
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://store.demoqa.com/";
            string title = driver.Title;
            int titleSize = driver.Title.Length;
            string url = driver.Url;
            int urlSize = driver.Url.Length;
            string pageSource = driver.PageSource;
            int pageSourceSize = driver.PageSource.Length;
            Console.WriteLine("Title: " + title + "\n" + "Title length: " + titleSize);
            Console.WriteLine("URL: " + url + "\n" + "URL length: " + urlSize);
            Console.WriteLine("Source length: " + pageSourceSize);
            driver.Quit();
        }
    }
}