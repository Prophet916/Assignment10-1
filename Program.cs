using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Implement quick sort algorithm.
             */

            int[] arr = { 10, 7, 8, 9, 1, 5 };
            Console.WriteLine("Original Array:");
            PrintArray(arr);

            QuickSortAlgorithm.QuickSort(arr);
            Console.WriteLine("\nSorted Array:");
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
