﻿using NUNIT_Framework.UIOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUNIT_Framework.Pages
{
    public class SearchEmpPage : UIActions
    {

        public static IWebElement PIMButton => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[2]/a/span"));
        public static IWebElement EmpName => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[1]/div/div[2]/div/div/input"));


        public static IWebElement SearchButton => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/button[2]"));
        public SearchEmpPage GoToSearch()
        {
            PIMButton.Click();
            Thread.Sleep(2000);
            EmpName.SendKeys("Rajesh");
            Thread.Sleep(2000);
            SearchButton.Click();
            Thread.Sleep(2000);

            return new SearchEmpPage();
        }
    }
}
