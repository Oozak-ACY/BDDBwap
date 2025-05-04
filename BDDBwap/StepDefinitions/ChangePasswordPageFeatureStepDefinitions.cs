using System;
using BDDBwap.Classe;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;

namespace BDDBwap.StepDefinitions
{
    [Binding]
    public class ChangePasswordPageFeatureStepDefinitions
    {
        [Given("I click on link {string}")]
        public void GivenIClickOnLink(string p0)
        {
            IWebElement linkElement = InitClass.Driver.FindElement(By.LinkText(p0));
            linkElement.Click();
        }

        [Given("I'm on change password page")]
        public void GivenImOnChangePasswordPage()
        {
            Assert.AreEqual(InitClass.Driver.Title, "bWAPP - Change Password");
        }



        [When("I fill inputs current_password with {string} and new_password with {string} and re_type_password with {string}")]
        public void WhenIFillInputsCurrent_PasswordWithAndNew_PasswordWithAndRe_Type_PasswordWith(string current, string password1, string password2)
        {
            IWebElement inputCurrent = InitClass.Driver.FindElement(By.Id("password_curr"));
            IWebElement inputNewPassword = InitClass.Driver.FindElement(By.Id("password_new"));
            IWebElement inputConfirmPassword = InitClass.Driver.FindElement(By.Id("password_conf"));
            inputCurrent.SendKeys(current);
            inputNewPassword.SendKeys(password1);
            inputConfirmPassword.SendKeys(password2);

        }

        [When("I click on button named {string}")]
        public void WhenIClickOnButtonNamed(string p1)
        {
            IWebElement buttonElement = InitClass.Driver.FindElement(By.Name(p1));
            buttonElement.Click();
        }


        [Then("I'm on change password page")]
        public void ThenImOnChangePasswordPage()
        {
            Assert.AreEqual(InitClass.Driver.Title, "bWAPP - Change Password");
        }
    }
}
