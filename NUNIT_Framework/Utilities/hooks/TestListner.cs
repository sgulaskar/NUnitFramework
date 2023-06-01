using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework;
using NUNIT_Framework.UIOperations;
using NUNIT_Framework.Utilities.Common;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUNIT_Framework.Utilities.hooks
{
    [TestFixture]
    public class TestListner :UIActions
    {
      

        
        [SetUp]
        public void StartTest()
        {
           
            new CommonTest().LaunchBrowser("Chrome");
            
            new CommonTest().NavigateTo("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            Thread.Sleep(2000);
        }
        [TearDown]
        public void EndTest()
        {
          
            GlobalVariables.driver.Quit();
        }
       

    }
}
