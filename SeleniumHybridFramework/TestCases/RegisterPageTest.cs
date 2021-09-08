using NUnit.Framework;
using SeleniumHybridFramework.BaseClass;
using SeleniumHybridFramework.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumHybridFramework.TestCases
{
    [TestFixture]
    public class RegisterPageTest:BaseTest
    {
        #region Variables
        string email = "vikw@gmail.com";
        string Fname = "Vikash";
        string Lname = "Kumar";
        string password = "Vikash2611";
        string date = "26";
        string month = "11";
        string year = "1989";
        string add = "Ranchi";
        string state = "Hawaii";
        string zip = "834005";
        string country = "United States";
        string mobNum = "8789791750";
        string aliasAdd = "My New Address";
        string title = "My account - My Store";

        #endregion
        #region Objects
        //Register register = new Register(driver);
        #endregion
        [Test]
        public void RegisterUser()
        {
            
            Register register = new Register(driver);
            System.Threading.Thread.Sleep(2000);
            register.RegSteps(email);
            //register.btnSubmit.Click();
            System.Threading.Thread.Sleep(200);
            register.radioGender.Click();
            register.txtFirstName.SendKeys(Fname);
            register.txtLastName.SendKeys(Lname);
            string val = register.txtEmailVerify.GetAttribute("value");
            Assert.AreEqual(email, val);

            register.txtPassword.SendKeys(password);
            register.SelectDateOfBirth(date, month, year);
            register.txtFirstNameOnAdd.SendKeys(Fname);
            register.txtLastNameOnAdd.SendKeys(Lname);
            register.txtAddress1.SendKeys(add);
            register.SelectState(state);
            register.txtPincode.SendKeys(zip);
            register.SelectCountry(country);
            register.txtMob.SendKeys(mobNum);
            register.txtAlias.SendKeys(aliasAdd);
            register.btnRegSubmit.Click();
            string actualTitle = driver.Title;

            Assert.AreEqual(title, actualTitle, "Somthing Went Wrong");

        }

    }
}
