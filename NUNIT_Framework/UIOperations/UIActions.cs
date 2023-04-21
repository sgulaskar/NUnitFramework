using OpenQA.Selenium;
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
        //New 
        public UIActions EnterText(IWebElement element, string textToEnter)
        {
            element.SendKeys(textToEnter);

            return new UIActions();
        }
        public UIActions EnterText1(IWebElement element, string textToEnter)
        {
            element.SendKeys(textToEnter);
            return new UIActions();
        }
        public UIActions ClickOn(IWebElement element)
        {
            element.Click();
            return new UIActions();
            
        }
        public UIActions ClickOn1(IWebElement element)
        {
            element.Click();
            return new UIActions();

        }
    }

}

