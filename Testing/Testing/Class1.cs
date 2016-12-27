using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using System.Drawing;
using OpenQA.Selenium.Interactions;

namespace Testing
{
    
    public class TestClass1 : SeleniumTestBase
    {
        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl(Wrapper.GetUrl());
            Driver.FindElement(By.XPath(".//*[@id='ac-gn-bag']/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='ac-gn-bagview-content']/nav/ul/li[5]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='login-appleId']")).SendKeys(Wrapper.GetAppleID());
            Driver.FindElement(By.XPath(".//*[@id='login-password']")).SendKeys(Wrapper.GetPassword());
            Driver.FindElement(By.XPath(".//*[@id='sign-in']")).Click();
        }

        [Test]
        public void Test2()
        {
            Driver.Navigate().GoToUrl(Wrapper.GetUrl());
            Driver.FindElement(By.XPath(".//*[@id='ac-globalnav']/div/ul[2]/li[9]/a")).Click();
            IWebElement qer = Driver.FindElement(By.Id("ac-gn-searchform-input"));
            qer.SendKeys("IPhone 7");
            qer.Submit();
            Driver.FindElement(By.XPath(".//*[@id='exploreCurated']/div[1]/div[2]/h2")).Click();
        }

        [Test]
        public void Test3()
        {
            Driver.Navigate().GoToUrl(Wrapper.GetUrl());
            Driver.FindElement(By.XPath(".//*[@id='ac-globalnav']/div/ul[2]/li[3]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='chapternav']/div/ul/li[1]/a/figure")).Click();
            Driver.FindElement(By.XPath(".//*[@id='ac-localnav']/div/div[2]/div/div[2]/div[2]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='Item112_9inch']")).Click();
            Driver.FindElement(By.XPath(".//*[@id='Item2gold']")).Click();
            Driver.FindElement(By.XPath(".//*[@id='Item3128gb']")).Click();
            Driver.FindElement(By.XPath(".//*[@id='primary']/div[4]/div[1]/div[1]/div/div[1]/div/form/div/span/button")).Click();
            Driver.FindElement(By.XPath(".//*[@id='engraving_form']/div[1]/div[2]/div[1]/fieldset/div[1]/ul/li[1]/label/div")).Click();
            Driver.FindElement(By.XPath(".//*[@id='line1']")).SendKeys("Za stranu i dvor");
            Driver.FindElement(By.XPath(".//*[@id='select_button']")).Click();
            Driver.FindElement(By.XPath(".//*[@id='actiontray']/div/div[2]/div/div/div[2]/button")).Click();
        }

        [Test]
        public void Test4()
        {
            Driver.Navigate().GoToUrl(Wrapper.GetUrl());
            Driver.FindElement(By.XPath(".//*[@id='ac-globalfooter']/div/section/div[2]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='europe']/ul/li[29]/a/span/span")).Click();
        }

        [Test]
        public void Test5()
        {
            Driver.Navigate().GoToUrl(Wrapper.GetUrl());
            Driver.FindElement(By.XPath(".//*[@id='ac-globalnav']/div/ul[2]/li[5]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='chapternav']/div/ul/li[4]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='main']/section[2]/div[1]/div/div/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='film-series2']")).Click();
            Thread.Sleep(10000);
            Driver.FindElement(By.XPath("html/body/div[6]/button")).Click();
        }

        [Test]
        public void FailedTest6()
        {
            Driver.Navigate().GoToUrl(Wrapper.GetUrl());
            Driver.FindElement(By.XPath(".//*[@id='ac-globalfooter']/div/nav/div[4]/div[1]/ul/li[1]/a")).Click();
            Thread.Sleep(5000);
            Driver.FindElement(By.Id("appleId")).SendKeys(Wrapper.GetAppleID());
            Driver.FindElement(By.Id("pwd")).SendKeys(Wrapper.GetPassword());
            Driver.FindElement(By.XPath(".//*[@id='sign-in']")).Click();
            Driver.FindElement(By.XPath(".//*[@id='security-content']/accordion/div/div/div/div[1]/div[2]/div/div/change-questions/div/div/button")).Click();
            new SelectElement(Driver.FindElement(By.XPath(".//*[@id='idms-step-1482240567547-0']/div[3]/security-questions-answers/div/div[1]/security-question/div/div[1]/select"))).SelectByIndex(1);
            Driver.FindElement(By.XPath(".//*[@id='idms-input-1482240567655-0']")).SendKeys("BULLDOG");
            new SelectElement(Driver.FindElement(By.XPath(".//*[@id='idms-step-1482241579453-0']/div[3]/security-questions-answers/div/div[2]/security-question/div/div[1]/select"))).SelectByIndex(4);
            Driver.FindElement(By.XPath(".//*[@id='idms-input-1482240567655-0']")).SendKeys("Adolf");
            new SelectElement(Driver.FindElement(By.XPath(".//*[@id='idms-step-1482241579453-0']/div[3]/security-questions-answers/div/div[3]/security-question/div/div[1]/select"))).SelectByIndex(6);
            Driver.FindElement(By.XPath(".//*[@id='idms-input-1482241579712-0']")).SendKeys("CSK");
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath(".//*[@id='idms-step-1482241579453-0']/div[4]/idms-toolbar/div/div/button[1]")).Click();
            Driver.FindElement(By.XPath(".//*[@id='answer1']")).SendKeys("BULLDOG");
            Driver.FindElement(By.XPath(".//*[@id='answer2']")).SendKeys("Adolf");
            Driver.FindElement(By.XPath(".//*[@id='challengeID']/div/div/div/div[2]/div/button[2]")).Click();
        }

        [Test]
        public void Test7()
        {
            Driver.Navigate().GoToUrl(Wrapper.GetUrl());
            Driver.FindElement(By.XPath(".//*[@id='ac-globalfooter']/div/nav/div[5]/div/ul/li[3]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='undefined-sticky-wrapper']/nav/div/ul/li[5]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='sn-function']")).Click();
            Driver.FindElement(By.XPath(".//*[@id='sn-function']")).Click();
            Driver.FindElement(By.XPath(".//*[@id='function-AnchorFix']/div/fieldset/ul/li[8]/span[1]")).Click();
            Driver.FindElement(By.XPath(".//*[@id='serviceAddress']")).SendKeys("Minsk");
            new SelectElement(Driver.FindElement(By.XPath(".//*[@id='service-products']"))).SelectByIndex(2);
            Driver.FindElement(By.XPath(".//*[@id='service-form-submit']")).Click();
        }

        [Test]
        public void Test8()
        {
            Driver.Navigate().GoToUrl(Wrapper.GetUrl());
            Driver.FindElement(By.XPath(".//*[@id='ac-globalfooter']/div/section/div[1]/span/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='service']/div")).Click();
        }

        [Test]
        public void Test9()
        {
            Driver.Navigate().GoToUrl(Wrapper.GetUrl());
            Driver.FindElement(By.XPath(".//*[@id='ac-gn-bag']/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='ac-gn-bagview-content']/nav/ul/li[3]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='login-appleId']")).SendKeys(Wrapper.GetAppleID());
            Driver.FindElement(By.XPath(".//*[@id='login-password']")).SendKeys(Wrapper.GetPassword());
            Driver.FindElement(By.XPath(".//*[@id='sign-in']")).Click();
            new SelectElement(Driver.FindElement(By.XPath(".//*[@id='order-filter-select']"))).SelectByIndex(5);
        }

        [Test]
        public void Test10()
        {
            Driver.Navigate().GoToUrl(Wrapper.GetUrl());
            Driver.FindElement(By.XPath(".//*[@id='ac-globalfooter']/div/section/div[3]/div[2]/a[5]")).Click();
            Driver.FindElement(By.XPath(".//*[@id='main']/section[12]/div/section/ul/li[1]/a")).Click();
            Driver.FindElement(By.XPath("html/body/div[5]/div[3]/div/div[2]/div/div/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='aw-page-wrapper']/div[3]/div/div[1]/div[2]/div[2]/div/div[2]/div[1]/ul/li[3]/div/button")).Click();
            Thread.Sleep(3000);
            Driver.FindElement(By.XPath(".//*[@id='aw-page-wrapper']/div[3]/div/div[1]/div[2]/div[2]/div/div[2]/div[3]/div[1]/div[2]/div/div/ul/li[36]/div/button")).Click();
            Driver.FindElement(By.XPath(".//*[@id='aw-page-wrapper']/div[4]/div/div/div/div/div[1]/div[3]/div/button")).Click();
            Thread.Sleep(3000);
            Driver.FindElement(By.XPath(".//*[@id='aw-page-wrapper']/div[3]/div/div[1]/div[2]/div[2]/div/div/div[2]/ul/li[1]/div/button")).Click();
            Driver.FindElement(By.XPath("html/body/div[1]/div/div[2]/div/div/div[3]/p[1]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='aw-page-wrapper']/div[3]/div/div[1]/div[2]/div[2]/div/div[2]/div[1]/div/ul/li[1]/div/button")).Click();
            Driver.FindElement(By.XPath(".//*[@id='aw-page-wrapper']/div[3]/div/div[1]/div[2]/div[2]/div/div/div/div[3]/ul/li[4]/div/button")).Click();
            Driver.FindElement(By.XPath(".//*[@id='aw-page-wrapper']/div[3]/div/div[1]/div[2]/div[2]/div/div/div[2]/ul/li[1]/div/button")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath(".//*[@id='awInput5']")).SendKeys("SR0001TST");
            Driver.FindElement(By.XPath(".//*[@id='aw-page-wrapper']/div[3]/div/div[1]/div[2]/div[2]/div/div/div[4]/div/div[1]/div[2]/div/div/div/div[2]/div[2]/div[1]/div/div/button")).Click();
        }

        [Test]
        public void Test11()
        {
            Driver.Navigate().GoToUrl(Wrapper.GetUrl());
            Driver.FindElement(By.XPath(".//*[@id='ac-globalfooter']/div/section/div[3]/div[2]/a[1]")).Click();
            Driver.FindElement(By.XPath("html/body/div[6]/section[1]/div/div/p[22]/a[2]")).Click();
            Driver.FindElement(By.XPath(".//*[@id='main']/section/ul/li[13]/h3/a")).Click();
            new SelectElement(Driver.FindElement(By.XPath(".//*[@id='feedback_type']"))).SelectByIndex(1);
            new SelectElement(Driver.FindElement(By.XPath(".//*[@id='country']"))).SelectByIndex(7);
            Driver.FindElement(By.XPath(".//*[@id='first_name']")).SendKeys("Test");
            Driver.FindElement(By.XPath(".//*[@id='last_name']")).SendKeys("Tester");
            Driver.FindElement(By.XPath(".//*[@id='customer_email']")).SendKeys(Wrapper.GetAppleID());
            Driver.FindElement(By.XPath(".//*[@id='subject']")).SendKeys("Test");
            Driver.FindElement(By.XPath(".//*[@id='comments']")).SendKeys("This is Test");
            Driver.FindElement(By.XPath(".//*[@id='privacy-issues']/input")).Click();
        }

        [Test]
        public void Test12()
        {
            Driver.Navigate().GoToUrl(Wrapper.GetUrl());
            Driver.FindElement(By.XPath(".//*[@id='ac-globalfooter']/div/section/div[3]/div[2]/a[4]")).Click();
            Driver.FindElement(By.XPath(".//*[@id='main']/section[2]/div[2]/a/span")).Click();
            Driver.FindElement(By.XPath(".//*[@id='main']/section/div[2]/ul/li[1]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='content']/table[1]/tbody/tr[2]/td[3]/p[1]/a")).Click();
        }

        [Test]
        public void Test13()
        {
            Driver.Navigate().GoToUrl(Wrapper.GetUrl());
            Driver.FindElement(By.XPath(".//*[@id='ac-globalnav']/div/ul[2]/li[4]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='chapternav']/div/ul/li[4]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='main']/section[3]/div[2]/div/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='ac-localnav']/div/div[2]/div/div[2]/div[2]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='accountname']")).SendKeys(Wrapper.GetAppleID());
            Driver.FindElement(By.XPath(".//*[@id='accountpassword']")).SendKeys(Wrapper.GetPassword());
            Driver.FindElement(By.XPath(".//*[@id='submitButton2']")).Click();
            Driver.FindElement(By.XPath(".//*[@id='main']/div[1]/div/section[2]/ul[1]/li/a")).Click();
        }

        [Test]
        public void Test14()
        {
            Driver.Navigate().GoToUrl(Wrapper.GetUrl());
            Driver.FindElement(By.XPath(".//*[@id='ac-gn-bag']/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='ac-gn-bagview-content']/nav/ul/li[5]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='login-appleId']")).SendKeys(Wrapper.GetAppleID());
            Driver.FindElement(By.XPath(".//*[@id='login-password']")).SendKeys(Wrapper.GetPassword());
            Driver.FindElement(By.XPath(".//*[@id='sign-in']")).Click();
            Thread.Sleep(2000);
            Driver.FindElement(By.XPath(".//*[@id='ac-globalnav']/div/ul[2]/li[9]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='ac-gn-searchresults']/section/ul/li[2]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='all-categories']/li[3]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='as-accessories']/div[3]/div[2]/div[1]")).Click();
            Driver.FindElement(By.XPath(".//*[@id='product-details-form']/div/div[2]/favorite/a")).Click();
        }

        [Test]
        public void FailedTest15()
        {
            Driver.Navigate().GoToUrl(Wrapper.GetUrl());
            Driver.FindElement(By.XPath(".//*[@id='ac-globalnav']/div/ul[2]/li[2]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='chapternav']/div/ul/li[9]/a")).Click();
            Driver.FindElement(By.XPath(".//*[@id='main']/section[2]/div/div[1]/div/a/div[1]")).Click();
            Driver.FindElement(By.XPath(".//*[@id='main']/section[2]/div/div[3]/div/a/div[1]")).Click();
            Thread.Sleep(2000);
            IWebElement e = Driver.FindElement(By.XPath(".//*[@id='main']/div/div[1]/p/a"));
            new Actions(Driver).MoveToElement(e).Perform();
            e.Click();
      
            Driver.FindElement(By.XPath(".//*[@id='gallery-macbook-3-trigger']/figure")).Click();
        }

        public void Wait(IWebElement we)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(we));
        }
        
    }
}
