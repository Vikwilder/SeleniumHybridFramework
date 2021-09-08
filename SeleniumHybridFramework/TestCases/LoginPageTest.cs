using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumHybridFramework.BaseClass;
using SeleniumHybridFramework.PageObjects;

namespace SeleniumHybridFramework.TestCases
{
    [TestFixture]
    public class LoginPageTest:BaseTest
    {
        [Test]
        public void VerifyLoginSucess()
        {
            
            Login loginPage = new Login(driver);
            loginPage.MobRechOnAmazon("8789791750", "50");
            System.Threading.Thread.Sleep(200);
        }
        
        
    }
}
