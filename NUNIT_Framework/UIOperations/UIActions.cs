using NUNIT_Framework.Utilities.hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V109.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUNIT_Framework.UIOperations
{
    public class UIActions : GlobalVariables
    {
        public UIActions UserName(IWebElement element, string Uname)
        {
            element.SendKeys(Uname);
            return new UIActions();
        }
        public UIActions Password(IWebElement element, string Pwd)
        {
            element.SendKeys(Pwd);
            return new UIActions();
        }
        public UIActions ClickOn(IWebElement element)
        {
            element.Click();
            return new UIActions();   
        }
        public UIActions FirstName(IWebElement fname, string firstname)
        {
            fname.SendKeys(firstname);
            return new UIActions();

        }
        public UIActions MiddleName(IWebElement mname, string middlename)
        {
            mname.SendKeys(middlename);
            return new UIActions();

        }
        public UIActions LastName(IWebElement lname, string lastname)
        {
            lname.SendKeys(lastname);
            return new UIActions();

        }
        public UIActions ClickOn1(IWebElement element)
        {
            element.Click();
            return new UIActions();
        }
         public bool IsElementPresent(IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch(Exception)
            {
                return false;     
            }
        }
     

    }

}

