using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework;
using NUNIT_Framework.Pages;
using NUNIT_Framework.Utilities.hooks;
using NUNIT_Framework.Utilities.XMLUtility;
using OpenQA.Selenium.DevTools.V109.DOMSnapshot;
using OpenQA.Selenium.DevTools.V109.Log;
using OpenQA.Selenium.DevTools.V109.Security;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NUNIT_Framework.Tests
{
    public class LoginOrangeHrm: TestListner
    {

        ExtentReports extent = null;
       

        LoginOrangeHRMPage loginpage = new LoginOrangeHRMPage();

        AddEmpPage adduser = new AddEmpPage();

        SearchEmpPage searchemp = new SearchEmpPage();

        BuzzPage buzzpage = new BuzzPage();

        DashboardPage dashpage = new DashboardPage();


        [OneTimeSetUp]
      
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Sangr\source\repos\Working Projects\NUnitFrameworkLatest\NUNIT_Framework\Reports\");
            extent.AttachReporter(htmlReporter);
        }

        
        [Test,Order(1)]
        //[Ignore("Login Test Ignore")]
        public void LoginTest()
        {
           
            loginpage.LoginOrangeHRM();
            Assert.IsTrue(dashpage.VerifyLogin());
        }

        [Test,Order(2)]
        public void AddEmp()
        {
            loginpage.LoginOrangeHRM();
            adduser.GoToAdd();
            string expected = "PIM";
            string actual = dashpage.verifyUserCreation();
            Assert.AreEqual(expected, actual);
        }

        [Test,Order(3)]
        public void SearchEmp()
        {
            loginpage.LoginOrangeHRM();
            searchemp.GoToSearch();
            string expected= XMLReader.XmlDataDocument("AddEmp", "firstname") + " " + XMLReader.XmlDataDocument("AddEmp", "middlename");
            string actual= dashpage.verifySearch();
            Assert.AreEqual(expected ,actual);
        }

        [Test, Order(4)]
        public void PostingBuzz()
        {
            loginpage.LoginOrangeHRM();
            buzzpage.BuzzPost();
          
        }
        [OneTimeTearDown]
        public void EndReport()
        {
            extent.Flush();
        }

    }


}
