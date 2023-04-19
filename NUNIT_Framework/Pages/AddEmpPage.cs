using NUNIT_Framework.UIOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace NUNIT_Framework.Pages
{
    public class AddEmpPage : UIActions
    {
        public static IWebElement PIMButton => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[2]/a/span"));

        public static IWebElement AddButton => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[2]/div[1]/button"));

        public static IWebElement Fname => driver.FindElement(By.Name("firstName"));

        public static IWebElement Mname => driver.FindElement(By.Name("middleName"));

        public static IWebElement Lname => driver.FindElement(By.Name("lastName"));

        public static IWebElement SaveButton => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[2]/button[2]"));
        
        public AddEmpPage GoToAdd()
        {
            PIMButton.Click();
            Thread.Sleep(2000);
            AddButton.Click();
            Thread.Sleep(2000);
             Fname.SendKeys("Rajesh");
            Thread.Sleep(2000);
            Mname.SendKeys("RajuAnna");
            Thread.Sleep(2000);
            Lname.SendKeys("Gangurde");
            Thread.Sleep(2000);
            SaveButton.Click();
            Thread.Sleep(3000);
            return new AddEmpPage();
        }
    }
}
