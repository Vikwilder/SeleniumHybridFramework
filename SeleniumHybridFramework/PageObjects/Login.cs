using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumHybridFramework.PageObjects
{
    
    public class Login
    {
        #region Variables
        //string userName = "mngr352295";
        //string passWord = "Aguheja";
        #endregion
        //IWebDriver driver;
        //[Obsolete]
        //public Login(IWebDriver driver)
        //{
        //    this.driver = driver;
        //    PageFactory.InitElements(driver, this);
        //}
        //[FindsBy(How = How.Id, Using = "message23")]
        //public IWebElement LoginBox { get; set; }
        //[FindsBy(How = How.Name, Using = "password")]
        //public IWebElement PasswordBox { get; set; }
        //[FindsBy(How = How.Name, Using = "btnLogin")]
        //public IWebElement LoginButton { get; set; }
        private readonly IWebDriver _driver;
        public Login(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement btnAmaPay => _driver.FindElement(By.XPath("//a[text()='Amazon Pay']"));
        public IWebElement mobileRech => _driver.FindElement(By.XPath("//span[text()='Mobile Recharge']"));
        public IWebElement txtMobileNum => _driver.FindElement(By.XPath("//input[@name='phoneNumber']"));
        public IWebElement txtRechAmmount => _driver.FindElement(By.XPath("//input[@name='rechargePlan']"));
        public IWebElement btnPay => _driver.FindElement(By.XPath("//button[@name='Buy']"));

        public void MobRechOnAmazon(string mobNo, string amount)
        {
            btnAmaPay.Click();
            System.Threading.Thread.Sleep(2000);
            mobileRech.Click();
            txtMobileNum.SendKeys(mobNo);
            System.Threading.Thread.Sleep(2000);
            txtRechAmmount.Click();
            System.Threading.Thread.Sleep(2000);
            btnPay.Click();
        }
        
    }
}
