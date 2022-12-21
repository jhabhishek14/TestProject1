using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal class TestBase
    {
        //here you can add steps to read data from json
        JsonConvert.DeserializeObject<>(System.IO.File.ReadAllText());

    }
}
