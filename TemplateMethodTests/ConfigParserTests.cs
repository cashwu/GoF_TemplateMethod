using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemplateMethod;

namespace TemplateMethod.Tests
{
    [TestClass()]
    public class ConfigParserTests
    {
        [TestMethod()]
        public void doParseTest()
        {
            ConfigParser fileParse = new FileConfigParser("c:\\config.ini");
            PersonData fpd = fileParse.doParse();
            Assert.AreEqual("Cash", fpd.Name);
            Assert.AreEqual(100, fpd.HP);

            ConfigParser dbParse = new DBConfigParse("http://127.0.0.1/hsql/mydb");
            PersonData dbpd = dbParse.doParse();
            Assert.AreEqual("Test", dbpd.Name);
            Assert.AreEqual(80, dbpd.HP);
        }
    }
}