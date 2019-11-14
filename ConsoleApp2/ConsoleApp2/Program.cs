using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int[] arr = { -3, 8, 4 };//change it
            //int[] sorted = SortArray(arr);
            //printArray(arr);
            //printArray(sorted);
            Console.WriteLine("Plese Enter a number:" );
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"PoliNum({x}) = {PoliNum(x)}");


        }

        static int[] SortArray(int[] arr)
        {
            //find the num minimal
            //put into sorted in the first place
            //find the rest
            int[] sorted = new int[arr.Length];
            int x = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int min = FindMin(arr, x);//find int in arr that>=x
                x = min;
                sorted[i] = min;
            }
            return sorted;
            //find min that large or equal than something 
            //put in the first in the sorted array 
        }

        static int FindMin(int[] arr, int x)
        {
            int ans = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] < ans && arr[i] > x)
                    ans = arr[i];
            return ans;
        }

        static void printArray(int[] arr)
        {
            Console.WriteLine("[{0}]", string.Join(", ", arr));

        }





        private static bool PoliNum(int num)
        {
            int countDigit = 0;
            int x = 1;
            int num_temp = num;
            int left_digit, rigth_digit; 

            //how much digit
            while (num_temp > 0)
            {
                num_temp /= 10;
                if (num_temp > 0)
                    countDigit++;
            }
            //digit = 3
            for (int i = 0; i < countDigit; i++)
            {
                x = x * 10;
            }

            while(num > 0)
            {
                left_digit = num / x;
                rigth_digit = num % 10;
                if (rigth_digit != left_digit)  
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

