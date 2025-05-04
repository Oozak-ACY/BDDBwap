using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using Reqnroll;
using BDDBwap.Classe;
using OpenQA.Selenium.Support.UI;

namespace BDDBwap.StepDefinitions
{
    [Binding]
    public class PortailPageFeatureStepDefinitions
    {


        [Given("I'm logged on portal page")]
        public void GivenImLoggedOnPortalPage()
        {
            IWebElement inputLogin = InitClass.Driver.FindElement(By.Id("login"));
            IWebElement inputPassword = InitClass.Driver.FindElement(By.Id("password"));
            IWebElement buttonElement = InitClass.Driver.FindElement(By.CssSelector("button[value='submit']"));
            inputLogin.SendKeys("bee");
            inputPassword.SendKeys("bug");
            buttonElement.Click();
            Assert.AreEqual(InitClass.Driver.Title, "bWAPP - Portal");

        }

        [When("I select option {string} on {string} selection")]
        public void WhenISelectOptionOnSelection(string optionValue, string selection)
        {
            IWebElement selectElement = InitClass.Driver.FindElement(By.Name(selection));

            SelectElement select = new SelectElement(selectElement);

            select.SelectByText(optionValue);

        }

        [When("I click on link {string}")]
        public void WhenIClickOnLink(string p0)
        {
            Thread.Sleep(2000);
            IWebElement linkElement = InitClass.Driver.FindElement(By.LinkText(p0));
            linkElement.Click();
        }

        [Then("I'm logged on portal page")]
        public void ThenImLoggedOnPortalPage()
        {
            Assert.AreEqual(InitClass.Driver.Title, "bWAPP - Portal");
        }

        [When("I confirm alert")]
        public void WhenIConfirmAlert()
        {
            IAlert alert = InitClass.Driver.SwitchTo().Alert();
            alert.Accept();
        }

        [When("I dismiss alert")]
        public void WhenIDismissAlert()
        {
            IAlert alert = InitClass.Driver.SwitchTo().Alert();
            alert.Dismiss();
        }



    }
}
