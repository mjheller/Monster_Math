using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace devCodeCampExtendedMath
{
    public class happyNumbers
    {
        List<int> Duplicates;
        List<int> squaredDigits;
        
        public happyNumbers()
        {
            Duplicates = new List<int>();
            squaredDigits = new List<int>();
        }
        public bool isHappy(int number)
        {
            int num = number;
            

            while (num != 1)
            {
                if (Duplicates.Contains(num))
                {
                    return false;
                }
                Duplicates.Add(num);
                

                string digitString = num.ToString();
                char[] digits = digitString.ToCharArray();

                foreach (int digit in digits)
                {
                    int result = digit * digit;
                    squaredDigits.Add(result);
                }
                num = squaredDigits.Sum();
                squaredDigits.Clear();
            }
            return true;
        }
    }
}
