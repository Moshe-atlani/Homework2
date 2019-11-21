using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class student
    {
        private string name;

        private static bool PoliNum(int num)
        {
            int countDigit = 0, x = 1, num2 = num, max, min;
            //how much digit
            while (num2 > 0)
            {
                num2 /= 10;
                if (num2 > 0)
                    countDigit++;
            }
            //digit = 3
            for (int i = 0; i < countDigit; i++)
            {
                x = x * 10;
            }

            for (int i = 0; i < countDigit; i++)
            {
                max = num / x;
                min = num % 10;
                if (min != max)
                {
                    return false;
                }
                else
                {
                    num %= x;
                    x /= 100;
                    num /= 10;
                }
            }
            return true;
        }

    }
}
