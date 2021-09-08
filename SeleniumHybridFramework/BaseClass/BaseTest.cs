using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumHybridFramework.BaseClass
{
    public class BaseTest
    {
        #region Variables        
        string url = "http://automationpractice.com/index.php";

        #endregion
        public static IWebDriver driver;
        

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);

        }

        [TearDown]
        public void Close()
        {
            driver.Dispose();
        }

       
        public void SendKeys()
        {
            

        }

    }
}
