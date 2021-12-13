using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using Assert = NUnit.Framework.Assert;

namespace CA3Tests
{
    [TestClass]
    public class CA3UnitTest
    {
        ChromeDriver driver = new ChromeDriver(Environment.CurrentDirectory);

        [TestMethod]
        public void FindHomePage()
        {
            driver.Navigate().GoToUrl("https://pwca3ead.z33.web.core.windows.net/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement HomePageHeader = driver.FindElement(By.Id("title"));
            Assert.IsTrue(HomePageHeader.Text.Contains("Anime Archive"));
        }
    }
}
