using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumHybridFramework.PageObjects
{
    public class Register
    {
        private readonly IWebDriver _driver;
        public Register(IWebDriver driver)
        {
            _driver = driver;
        }
        //WebDriverWait myWait = new WebDriverWait(IWebDriver driver, TimeSpan.FromSeconds(10));
        public IWebElement btnSignIn => _driver.FindElement(By.XPath("//div[@class='header_user_info']//a"));
        public IWebElement txtEmailId => _driver.FindElement(By.Id("email_create"));
        public IWebElement btnSubmit => _driver.FindElement(By.Id("SubmitCreate"));
        public IWebElement radioGender => _driver.FindElement(By.XPath("//div[@id='uniform-id_gender1']"));
        public IWebElement txtFirstName => _driver.FindElement(By.Id("customer_firstname"));
        public IWebElement txtLastName => _driver.FindElement(By.Id("customer_lastname"));
        public IWebElement txtEmailVerify => _driver.FindElement(By.Id("email"));
        public IWebElement txtPassword => _driver.FindElement(By.Id("passwd"));
        public IWebElement drpDateOnDOB => _driver.FindElement(By.Id("days"));
        public IWebElement drpMonthOnDOB => _driver.FindElement(By.Id("months"));
        public IWebElement drpYearOnDOB => _driver.FindElement(By.Id("years"));
        public IWebElement txtFirstNameOnAdd => _driver.FindElement(By.Id("firstname"));
        public IWebElement txtLastNameOnAdd => _driver.FindElement(By.Id("lastname"));        
        public IWebElement txtAddress1 => _driver.FindElement(By.Id("address1"));
        public IWebElement txtCity => _driver.FindElement(By.Id("city"));
        public IWebElement drpState => _driver.FindElement(By.Id("id_state"));
        public IWebElement txtPincode => _driver.FindElement(By.Id("postcode"));
        public IWebElement drpCountry => _driver.FindElement(By.Id("id_country"));
        public IWebElement txtMob => _driver.FindElement(By.Id("phone_mobile"));
        public IWebElement btnRegSubmit => _driver.FindElement(By.Id("submitAccount"));
        public IWebElement txtAlias => _driver.FindElement(By.Id("alias"));
        
        




        public void RegSteps(string emailID)
        {
            btnSignIn.Click();
            txtEmailId.SendKeys(emailID);
            btnSubmit.Click();
        }
        public void SelectDateOfBirth(string date, string month, string year)
        {
            SelectElement selDate = new SelectElement(drpDateOnDOB);
            selDate.SelectByValue(date);
            System.Threading.Thread.Sleep(1000);
            selDate.SelectByValue(month);
            System.Threading.Thread.Sleep(1000);
            selDate.SelectByValue(year);
            System.Threading.Thread.Sleep(1000);

        }
        public void SelectState(string state)
        {
            SelectElement selState = new SelectElement(drpState);
            selState.SelectByValue(state);
        }
        public void SelectCountry(string country)
        {
            SelectElement selCountry = new SelectElement(drpCountry);
            selCountry.SelectByValue(country);
        }
        

    }
}
