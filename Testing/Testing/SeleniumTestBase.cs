using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    [TestFixture]
    public abstract class SeleniumTestBase
    {
        protected IWebDriver Driver;

        [TestFixtureSetUp]
        public void TestInitialize()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(200));
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(200));
        }

        [TestFixtureTearDown]
        public void TestCleanup()
        {
            Driver.Quit();
        }

        [SetUp]
        public void OneSetUp()
        {
            Driver.Manage().Window.Maximize();
            Driver.Manage().Cookies.DeleteAllCookies();
        }

        [TearDown]
        public void OneTearDown()
        {
            
        }
    }
}
