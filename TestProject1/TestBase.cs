using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V106.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Model;

namespace TestProject1
{
    internal class TestBase
    {
        internal IWebDriver driver;
        internal dynamic  Browser;
        public static List<WatchesModel> Watch;

        //defing the scope of "Watch" at class level which can be use project wise after inheriting
        public void SetUp()
        {
            var CurrentDirectory = AppContext.BaseDirectory;
            //here you can add steps to read data from json
            Watch = JsonConvert.DeserializeObject<List<WatchesModel>>
            (System.IO.File.ReadAllText(Path.Combine(CurrentDirectory,"data","","Watches.json")));

            //You can also read multiple json from testbase. 

            
            

        }

        //Pending todo -- to read data from runsetting files
        public void TestInitialization(TestContext testContext)
        {var  Browser = testContext.["Browser"].ToString(); }


        

    }
    
}
