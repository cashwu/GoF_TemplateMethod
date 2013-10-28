using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }

    public class PersonData
    {
        public string Name { get; set; }

        public int HP { get; set; }
    }

    /// <summary>
    /// http://www.dotblogs.com.tw/hatelove/archive/2011/12/10/template-method-by-interface.aspx
    /// </summary>
    public abstract class ConfigParser
    {
        protected PersonData mPData = null;

        public PersonData doParse()
        {
            readData();
            parseToken();
            buildModel();
            validate();
            return mPData;
        }

        protected virtual void readData()
        {
        }

        protected virtual void parseToken()
        {
        }

        abstract protected void buildModel();

        protected virtual void validate()
        {
        }
    }

    public class FileConfigParser : ConfigParser
    {
        private String mFileName = null;

        public FileConfigParser(string fileName)
        {
            this.mFileName = fileName;
        }

        protected override void buildModel()
        {
            mPData = new PersonData();
            mPData.Name = "Cash";
            mPData.HP = 100;
        }
    }

    public class DBConfigParse : ConfigParser
    {
        private String mFileName = null;

        public DBConfigParse(string fileName)
        {
            this.mFileName = fileName;
        }

        protected override void buildModel()
        {
            mPData = new PersonData();
            mPData.Name = "Test";
            mPData.HP = 80;
        }
    }
}