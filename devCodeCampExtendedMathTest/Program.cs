using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using devCodeCampExtendedMath;

namespace devCodeCampExtendedMathTest
{
    class Math
    {

        static void Main(string[] args)
        {
            int index = 1;
            List<int> happyNumberList;
            happyNumbers happyNumbers = new happyNumbers();
            happyNumberList = happyNumbers.toNthHappyNumber(2000);
            foreach(int i in happyNumberList)
            {
                Console.WriteLine("HappyNumber " + i + " -- Count  " + index);
                index++;
            }
            string keepopen = Console.ReadLine();
        }
    }
}

