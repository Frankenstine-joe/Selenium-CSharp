using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Net;
using System.Collections.Generic;

//nmock.dll, nunit.core.dll, nunit. framework.dll, ThoughtWorks.Selenium.Core.dll, ThoughtWorks.Selenium.IntegrationTests.dll and ThoughtWorks.Selenium.UnitTests.dll

namespace Selenium_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Chrome Proxy Option

            //Chrome Options
            //ChromeOptions options = new ChromeOptions();

            //Proxy proxy = new Proxy();
            //proxy.Kind = ProxyKind.Manual;
            //proxy.IsAutoDetect = false;
            //proxy.HttpProxy =
            //proxy.SslProxy = "127.0.0.1:3330";
            // From Thailand
            //proxy.SslProxy = "103.14.8.239:8080";

            //From Uk
            //proxy.SslProxy = "217.33.216.114:8080"; 
            //options.Proxy = proxy;
            //options.AddArgument("ignore-certificate-errors");
            //var chromedriver = new ChromeDriver(options);

            #endregion

            // Main Code - Instantiate chrome browser

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.co.uk/?#q=sony&*";
            //driver.Url = "https://www.google.co.uk";

            // For Proxy Enabled
            // IWebDriver driver = new ChromeDriver(options);

            Thread.Sleep(4000);
            //driver.Url = "http://www.gmail.com";

            #region Get Page Source

            // Get Page source
            //Console.WriteLine("*****************");
            //Console.WriteLine(driver.PageSource);
            //Console.WriteLine("*****************");

            #endregion

            #region Get Title

            //Console.WriteLine(driver.Title);

            #endregion

            #region Close One and All tabs 

            // Closing one tab vs all tabs
            //driver.Url = "http://demoqa.com/frames-and-windows/";
            //driver.FindElement(By.XPath(".//*[@id='tabs-1']/div/p/a")).Click();
            //driver.Close();

            #endregion

            #region Navigate through all browser controls
            // Navigate through Back and forward in browser

            //Thread.Sleep(5000);
            //driver.Navigate().Back();
            //driver.Navigate().Forward();
            //driver.Navigate().Refresh();
            //driver.Navigate().GoToUrl("url");
            #endregion

            #region Web Element

            // Class Name
            //IWebElement element = driver.FindElement(By.ClassName("gsfi"));


            // Selecting Elemet By ID
            //element = driver.FindElement(By.Id("Yaba Daba Doo"));
            //List<IWebElement> Elements = driver.FindElements(By.ClassName("_Rm"));
            //element = driver.FindElements(By.ClassName("_Rm"))

            // Several things we can get via IWebDriver
            //element = driver.Url;

            // Performing Operations on that selection
            //element.Clear();
            //element.Click();
            //element.Displayed;
            //element.FindElement(); As seen above
            //element.GetAttribute("Attribute Name");
            //element.GetCssValue("Property Name");
            //element.Location
            //element.SendKeys("asd");  // Simulates key presses
            //element.Size;  // Get Width and height
            //element.Submit();
            //element.Text

            //Console.WriteLine(element.Text);

            //element.Click();

            //element.SendKeys("ducati");
            //element.Submit();

            #endregion

            #region Find Elements

            //IWebElement element = driver.FindElement(By.ClassName("gsfi"));
            IList<IWebElement> AllLinks = driver.FindElements(By.ClassName("_Rm"));

            foreach (var item in AllLinks)
            {
                Console.WriteLine(item.Text);
            }


            #endregion

        }
    }
}


//namespace SeleniumTests
//{
//    [TestFixture]
//    public class NewTest
//    {
//        private ISelenium selenium;
//        private StringBuilder verificationErrors;

//        [SetUp]
//        public void SetupTest()
//        {
//            selenium = new DefaultSelenium("localhost", 4444, "*firefox", "http://www.google.com/");
//            selenium.Start();
//            verificationErrors = new StringBuilder();
//        }

//        [TearDown]
//        public void TeardownTest()
//        {
//            try
//            {
//                selenium.Stop();
//            }
//            catch (Exception)
//            {
//                // Ignore errors if unable to close the browser
//            }
//            Assert.AreEqual("", verificationErrors.ToString());
//        }

//        [Test]
//        public void TheNewTest()
//        {
//            selenium.Open("/");
//            selenium.Type("q", "selenium rc");
//            selenium.Click("btnG");
//            selenium.WaitForPageToLoad("30000");
//            Assert.AreEqual("selenium rc - Google Search", selenium.GetTitle());
//        }
//    }
//}

