using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace devCodeCampExtendedMath
{
    class Math
    {
        
        static void Main(string[] args)
        {
            List<int> happyNumList = new List<int>();
            int happyNumberCount = 0;
            happyNumbers happyNumbers = new happyNumbers();
            int num = 1;

            while (happyNumberCount <= 1001) 
            {
                if (happyNumbers.isHappy(num))
                {
                    Console.WriteLine("HAPPY!" + num);
                    happyNumList.Add(num);
                    happyNumberCount += 1;
                    num += 1;
                    
                } else
                {
                    num += 1;
                }
            }
            foreach (int n in happyNumList)
            {
                Console.WriteLine(n.ToString());
            }
            string keepopen = Console.ReadLine();
        }
    }
}
