using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using Reqnroll;
using BDDBwap.Classe;
using OpenQA.Selenium.Support.UI;

namespace BDDBwap.StepDefinitions
{
    [Binding]
    public class LoginPageFeatureStepDefinitions
    {


        [Given("I'm on login page")]
        public void GivenImOnLoginPage()
        {
            Assert.AreEqual(InitClass.Driver.Title, "bWAPP - Login");
        }

        [When("I fill inputs login with {string} and password with {string}")]
        public void WhenIFillInputsLoginWithAndPasswordWith(string loginValue, string passwordValue)
        {
            IWebElement inputLogin = InitClass.Driver.FindElement(By.Id("login"));
            IWebElement inputPassword = InitClass.Driver.FindElement(By.Id("password"));
            inputLogin.SendKeys(loginValue);
            inputPassword.SendKeys(passwordValue);
        }

        [When("I click on button {string}")]
        public void WhenIClickOnButton(string button)
        {
            IWebElement buttonElement = InitClass.Driver.FindElement(By.CssSelector("button[value='submit']"));
            buttonElement.Click();
        }

        [Then("I get a message {string}")]
        public void ThenIGetAMessage(string p0)
        {
            WebDriverWait wait = new WebDriverWait(InitClass.Driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(driver => driver.FindElement(By.XPath($"//*[contains(normalize-space(string()), \"{p0}\")]")));

            Assert.IsNotNull(element);
        }

        [Then("I'm redirected on {string}")]
        public void ThenImRedirectedOn(string p0)
        {
            WebDriverWait wait = new WebDriverWait(InitClass.Driver, TimeSpan.FromSeconds(10));
            wait.Until(driver => driver.Title.Contains(p0));
            Assert.AreEqual(p0, InitClass.Driver.Title);
        }

        [Then("I'm on login page")]
        public void ThenImOnLoginPage()
        {
            Assert.AreEqual(InitClass.Driver.Title, "bWAPP - Login");
        }

    }
}
