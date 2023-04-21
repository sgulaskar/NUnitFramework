using NUnit.Framework;
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
    public class BuzzPage : UIActions
    {
        //This is BuzzPage
        public static IWebElement BuzzButton => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[11]/a"));

        public static IWebElement TextBox => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div/div[1]/div[1]/div[2]/form/div/textarea"));

        public static IWebElement PostButton => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div/div[1]/div[1]/div[2]/form/div/div/button"));
        public BuzzPage BuzzPost()
        {
            BuzzButton.Click();
            Thread.Sleep(2000);
            TextBox.SendKeys("Hello Automation");
            Thread.Sleep(2000);
            PostButton.Click();
            Thread.Sleep(2000);



            return new BuzzPage();

        }
    }
}
