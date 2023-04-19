using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUNIT_Framework.Utilities.hooks
{
    [SetUpFixture]
    public class FixtureListner
    {
        [OneTimeSetUp]
        public void SetUpEnvironment()
        {
           
        }
        [OneTimeTearDown]
        public void TearDownEnvironment() 
       {
        
        }
    }
}