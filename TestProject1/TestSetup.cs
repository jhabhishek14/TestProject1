using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal class TestSetup
    {
        public static ILogger Log;
        //The responsibility of the ILogger interface is to write a log message of a given log level
        public static IConfiguration config;
        //The IConfiguration interface is used to read Settings and Connection Strings from AppSettings file.

        [OneTimeSetUp]
        public void RunBeforeAnyTest()
        {
            if(TestContext.Parameters.Count == 0)
            {
                throw new Exception("Run Setting file is not selected");
            }

            

        }
    }
}
