using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    internal class Class1
    {

        public static void main(string[] args)
        {
            int sum = 0;
            int Number = 123454321;
            int Remainder;
            int temp = Number;

            while(Number>0)
            {
                Remainder = Number % 10;

                sum = (sum % 10) + Remainder;

                Number = Number / 10;

            }

        }
    }
}
