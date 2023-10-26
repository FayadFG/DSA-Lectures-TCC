using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Binary_Search_Homework
{
    internal class Program
    {
         static void Main(string[] args) // feel free to edit the main method as you like
        {
            int rpet = 1;
            do
            {
                int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                int key;
                Console.Write("Enter the number you want to search for =");
                key = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                // int idx = BinarySearchHomework.TernarySearch(arr1, key);
                int idx = BinarySearchHomework.TernarySearch(arr1, key, 0, arr1.Length);

                Console.WriteLine("Found {0} at index {1} using Ternary Search", key, idx);

                Console.WriteLine("=======================");

                int[] arr2 = { 1, 2, 2, 2, 3, 4, 5, 5, 5, 5, 5, 6, 7, 7, 8, 9 };
                int key2;
                Console.Write("Enter the number you want to know the number of times it repeats = ");
                key2 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();

                int repeat_count = BinarySearchHomework.GetRepeatCount(arr2, key2);

                Console.WriteLine("The number {0} is repeated {1} times", key2, repeat_count);
                Console.WriteLine();

                Console.Write("If You want Exit Press 0 else Press any number =");
                rpet = Convert.ToInt16(Console.ReadLine());
            } while (rpet != 0);
        }
    }
}
