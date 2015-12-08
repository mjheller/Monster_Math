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
        List<int> happyList;
        public bool isHappy(int num)
        {
            if (num == 1)
            {
                return true;
            }
            List<int> duplicates = new List<int>();
            duplicates.Add(num);
            int prev = num;
            int next;

            while (true)
            {
                next = sumOfSquaredDigits(prev);
                if (next == 1)  return true;
                if (duplicates.Contains(next)) break;   
                duplicates.Add(next);
                prev = next;
            }

            return false;
        }
        public int sumOfSquaredDigits(int num)
            {
                int sum = 0;
                foreach (char digit in num.ToString()) sum += (digit - 48) * (digit - 48);
                return sum;
            }

        public List<int> toNthHappyNumber(int happyCount)
        {
            int counter = 0;
            happyList = new List<int>();
            for(int i = 1; counter < happyCount; i++)
            {
                if (isHappy(i))
                {
                    happyList.Add(i);
                    counter++;
                }
            }
            return happyList;
        }
    }
}

