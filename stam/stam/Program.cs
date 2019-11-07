using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountEventDigit(12344));
        }
        static int Foo(bool b1, bool b2, Stack s)
        {
            if (b1 == true && b2 == true)
            {
                int x, count = 0;
                while (!s.IsEmpty())
                {
                    x = s.Top();
                    if (CountDigit(x) / 2 < CountEventDigit(x))
                        count++;
                    s.Pop();
                }
                return count;
            }
            else if (b1 == false && b2 == false)
            {
                int x, count = 0;
                while (!s.IsEmpty())
                {
                    x = s.Top();
                    if (CountDigit(x) / 2 <CountEventDigit(x))
                        count++;
                    s.Pop();
                }
                return count;
            }
            else
            {
                int x, count = 0;
                while (!s.IsEmpty())
                {
                    x = s.Top();
                    if (CountDigit(x) / 2 == CountEventDigit(x))
                        count++;
                    s.Pop();
                }
                return count;
            }

        }
        static int CountEventDigit(int num)
        {
            int x, count = 0;

            while (num > 0)
            {
                x = num % 10;
                if (x % 2 == 0)
                    count++;
                num /= 10;
            }
            return count;
        }
        static int CountDigit(int num)
        {
            int count = 0;
            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            return count;
        }
    }
}
