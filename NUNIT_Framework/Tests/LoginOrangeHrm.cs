using NUnit.Framework;
using NUNIT_Framework.Pages;
using NUNIT_Framework.Utilities.hooks;
using OpenQA.Selenium.DevTools.V109.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUNIT_Framework.Tests
{
    public class LoginOrangeHrm: TestListner
    {
        LoginOrangeHRMPage loginpage = new LoginOrangeHRMPage();

        AddEmpPage adduser = new AddEmpPage();

        SearchEmpPage searchemp = new SearchEmpPage();
       
        [Test]
        public void LoginTest()
        {
            loginpage.LoginOrangeHRM();

        }
        [Test]
        public void AddEmp()
        {
            loginpage.LoginOrangeHRM();
            adduser.GoToAdd();


        }
        [Test]
        public void SearchEmp()
        {
            loginpage.LoginOrangeHRM();
        
            searchemp.GoToSearch();

        }
    }
}
