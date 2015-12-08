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
            happyNumberList = MathBlaster.toNthHappyNumber(2);
            foreach (int i in happyNumberList)
            {
                Console.WriteLine("HappyNumber " + i + " -- Count  " + index);
                index++;
            }
        //Euclidean
            int test = MathBlaster.Euclideanize(833, 324);
            Console.WriteLine("\n EUCLIDEAN");
            Console.WriteLine("Euclideanize: " + test);
            
       //RomanNumeral
            string num = "55";
            MathBlaster.RomanNumeralInteragize(ref num);
            Console.WriteLine("\n ROMAN NUMERAL INTERAGIZE");
            Console.WriteLine(num);

       //NarcissisticNumbers
            Console.WriteLine("\n Narcissistic Numbers");
            MathBlaster.toNthNarcissisticNumber(20);
            string keepopen = Console.ReadLine();



        }
    }
}

