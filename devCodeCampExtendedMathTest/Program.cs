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
        //HappyNumber
            happyNumberList = MathBlaster.toNthHappyNumber(1000);
            foreach (int i in happyNumberList)
            {
                Console.WriteLine("HappyNumber " + i + " -- Count  " + index);
                index++;
            }
        //Euclidean
            int test = MathBlaster.Euclideanize(833, 324);
            Console.WriteLine("EUCLIDEAN");
            Console.WriteLine("Euclideanize: " + test);
            
       //RomanNumeral
            string num = "55";
            MathBlaster.RomanNumeralInteragize(ref num);
            Console.WriteLine("ROMAN NUMERAL INTERAGIZE");
            Console.WriteLine(num);
            string wait = Console.ReadLine();
            
            

            

        }
    }
}

