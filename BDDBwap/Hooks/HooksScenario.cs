using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDDBwap.Classe;

namespace BDDBwap.Hooks
{
    [Binding]
    public class InitScenarioHook
    {
        [BeforeScenario]
        public static void InitScenario()
        {
            InitClass.Driver = new FirefoxDriver();
            InitClass.Driver.Navigate().GoToUrl("http://localhost/login.php");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            InitClass.Driver.Quit();
        }
    }
}
