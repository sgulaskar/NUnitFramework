using NUNIT_Framework.Pages;
using NUNIT_Framework.UIOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUNIT_Framework.Tests
{
    public class DashboardPage : UIActions
    {
        public static IWebElement dashboardLabel => driver.FindElement(By.XPath("//span/h6"));
        public static IWebElement NewUserDetailsLabel => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[1]/div[1]/span/h6"));
        public static IWebElement RecordFound => driver.FindElement(By.XPath("//div[contains(text(),'John steve')]"));
        public bool VerifyLogin()
        {
            return IsElementPresent(dashboardLabel);
        }
        public string verifyUserCreation()
        {
            return NewUserDetailsLabel.Text;
        }
        public string verifySearch()
        {
            return RecordFound.Text;
        }
    }
}
