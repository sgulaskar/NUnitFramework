using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace NUNIT_Framework.Utilities.XMLUtility
{
    public class XMLReader
    {
        public static string XmlDataDocument(string XMLFilename,string tagName)
        {
            try
            {
                XmlDocument xdoc1 = new XmlDocument();
                string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string path = Path.Combine(dir, "TestData");
                string file = XMLFilename + ".xml";
                xdoc1.Load(Path.Combine(path, file));
                return xdoc1.SelectSingleNode(".//" + tagName).InnerText;
            }
            catch(Exception)
            {
                return "Issue occured in XML reader or in XML file name";
            }
        }
    }
}
