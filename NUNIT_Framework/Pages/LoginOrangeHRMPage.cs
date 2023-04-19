using NUNIT_Framework.UIOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUNIT_Framework.Pages
{
    public class LoginOrangeHRMPage : UIActions
    {
        public static IWebElement uname=> driver.FindElement(By.Name("username"));
        public static IWebElement pwd => driver.FindElement(By.Name("password"));
        public static IWebElement LoginButton => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button"));
        
        public LoginOrangeHRMPage LoginOrangeHRM()
        {
            EnterText(uname, "Admin");
            EnterText1(pwd, "admin123");
            ClickOn(LoginButton);
            Thread.Sleep(2000);

            return new LoginOrangeHRMPage();
        }

    }
}
