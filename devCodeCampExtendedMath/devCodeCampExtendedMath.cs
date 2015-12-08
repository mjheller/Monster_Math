using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace devCodeCampExtendedMath
{

    public class MathBlaster
    {

        public static bool isHappy(int num)
        {
            if (num == 1)
            {
                return true;
            }
            List<int> duplicates = new List<int>();
            duplicates.Add(num);
            int next;

            while (true)
            {
                next = sumOfSquaredDigits(num);
                if (next == 1)
                    return true;
                if (duplicates.Contains(next))
                    break;
                duplicates.Add(next);
                num = next;
            }
            return false;
        }
        public static int sumOfSquaredDigits(int num)
        {
            int sum = 0;
            foreach (char digit in num.ToString()) sum += (digit - 48) * (digit - 48);
            return sum;
        }
        public static List<int> toNthHappyNumber(int happyCount)
        {
            List<int> happyList;

            int counter = 0;
            happyList = new List<int>();
            for (int i = 1; counter < happyCount; i++)
            {
                if (isHappy(i))
                {
                    happyList.Add(i);
                    counter++;
                }
            }
            return happyList;
        }


        public static int Euclideanize(int num1, int num2)
        {
            if (num2 == 0)
            {
                return num1;
            } else if (num1 == 0)
            {
                return num2;
            } else if (num1 > num2)
            {
                int remainder = num1 % num2;
                return Euclideanize(num2, remainder);
            } else
            {
                int remainder = num2 % num1;
                return Euclideanize(num1, remainder);
            }
  
        }


        public static void RomanNumeralInteragize(ref string num)
        {

            int number = Convert.ToInt32(num);
            string romanNumeral = "";
            Dictionary<int, string> RNDict = new Dictionary<int, string>
            {
                {1,"I" },
                {4,"IV" },
                {5,"V" },
                {9,"IX" },
                {10,"X" },
                {40,"XL" },
                {50,"L" },
                {90,"XC" },
                {100,"C" },
                {400,"CD" },
                {500,"D" },
                {900,"CM" },
                {1000, "M" }
            };
            
            while (number > 0)
            {
                for (int n = number; n > 0; n--)
                {
                    if (RNDict.Keys.Any(key => key == n))
                    {
                        string value = RNDict[n];
                        number -= n;
                        romanNumeral += value;
                        break;
                    }
                }
            }
            num = romanNumeral;

        }
        public static bool isNarcissistic(int num)
        {
            if (num < 0)
                return false;
            string numberString = num.ToString();
            int sum = 0;
            int intLength = numberString.Length;
            foreach (char c in numberString)
                sum += Convert.ToInt32(Math.Pow(Convert.ToDouble(c - 48), intLength));

            return sum == num;
        }
        public static void toNthNarcissisticNumber(int count)
        {
            int counter = 0;
            int x = 0;
            while (counter < count)
            {
                if (isNarcissistic(x))
                {
                    Console.WriteLine(x);
                    counter++;
                }
                x++;
            }

        }
    }
}

