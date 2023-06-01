using NUnit.Framework;
using NUNIT_Framework.Utilities.hooks;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;

namespace NUNIT_Framework.Utilities.Common
{
    [TestFixture]
    public class CommonTest : GlobalVariables
    {
        public CommonTest LaunchBrowser(string browserType)
        {
          
            try
            {
                switch (browserType.ToUpper())
                {
                    case "CHROME":
                        driver = new ChromeDriver();
                        driver.Manage().Window.Maximize();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception e)
            {
            
            }
            return new CommonTest();
        }
        public void NavigateTo(string URL)
        {
            try
            {
                driver.Navigate().GoToUrl(URL);
            }
            catch (Exception e)
            { }
        }
        public void CloseProcess(string ProceesName)
        {
            try
            {
                foreach (var process in Process.GetProcessesByName(ProceesName))
                {
                    process.Kill();
                }

            }
            catch (Exception e) { }
            
        }
        
    }   
}
