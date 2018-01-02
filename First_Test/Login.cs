using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace First_Test
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginTest()
        {
            IWebDriver driver = new ChromeDriver("D:\\Programs\\Microsoft Visual Studio\\Drivers");
            driver.Url = "http://www.google.bg";
            var input = driver.FindElement(By.Name("q"));
            input.SendKeys("selenium");
            input.Submit();
        }
    }
}