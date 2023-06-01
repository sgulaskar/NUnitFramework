using AventStack.ExtentReports;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Execution;
using NUNIT_Framework.UIOperations;
using NUNIT_Framework.Utilities.XMLUtility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace NUNIT_Framework.Pages
{
    public class LoginOrangeHRMPage : UIActions
    {
      
        public static IWebElement Uname => driver.FindElement(By.Name("username"));
        public static IWebElement Pwd => driver.FindElement(By.Name("password"));
        public static IWebElement LoginButton => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button"));

        public LoginOrangeHRMPage LoginOrangeHRM()
        {
            UserName(Uname, XMLReader.XmlDataDocument("LoginData", "username"));

            Password(Pwd, XMLReader.XmlDataDocument("LoginData", "password"));
         
            ClickOn(LoginButton);
            Thread.Sleep(2000);

            return new LoginOrangeHRMPage();
        }

    }
}
