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

        public void RunBeforeAnyTest()
        {
            if(TestContext.Parameters.Count == 0)
            {
                throw new Exception("Run Setting file is not selected");
            }

            

        }
    }
}
