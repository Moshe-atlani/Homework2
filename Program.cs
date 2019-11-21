using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurssion1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1,1,2,3,5,8,13,21,34... Fibunacchi
            Console.WriteLine("Please enter a number: ");
            int n = int.Parse(Console.ReadLine());

            var watch = System.Diagnostics.Stopwatch.StartNew();
            long fibn = FibIter(n);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine($"Fib({n}) = {fibn}");
            Console.WriteLine($"Time: {elapsedMs/1000.0}");

        }


        public static long FibIter(int n)
        {
            // n=3 => 
            if (n == 0 || n == 1)
                return 1;

            long first = 1;
            long second = 1;

            for (int i=1; i< n; i++)
            {
                long first_temp = first;
                first = second;
                second = first_temp + first;
                
            }
            return second;
        }

        // בשיעור הבא נעשה את זה יותר מהיר
        public static long FibRec(int n)
        {
            // n=1, n=0
            if (n == 1 || n == 0)
            {
                return 1;
            }

            // רקורסיה
            return FibRec(n - 1) + FibRec(n - 2);
        }
    }
}
