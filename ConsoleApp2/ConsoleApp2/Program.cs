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
            int[] arr = { 1, 8, 7, 3 };//change it
            int[] sorted = SortArray(arr);
            printArray(arr);
            printArray(sorted);

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

    }
}

