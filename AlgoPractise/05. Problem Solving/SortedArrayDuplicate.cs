
// Interview perp. Subeen: chap 03
// Remove duplicates from a sorted array, Dont use additional array


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractise._05._Problem_Solving
{
    internal class SortedArrayDuplicate
    {
        static int[] input = { 0, 1, 1, 1, 2, 3, 4, 4, 4, 4, 6, 7, 23 };

        static internal void RemoveDuplicate()
        {
            int lastSortedIndex = 0, arrayLength = input.Length;

            for(int i = 1;i<arrayLength; i++)
            {
                if (input[i] == input[lastSortedIndex]) continue;
                input[++lastSortedIndex] = input[i];
            }
        }

        static internal void CheckCurrentArray()
        {
            for(int i=0;i<input.Length;i++)
            {
                Console.Write(String.Format("{0} ", input[i]));
            }
            Console.WriteLine();    
            Console.ReadKey();
        }

        internal static void Run()
        {
            RemoveDuplicate();
            CheckCurrentArray();
        }
    }
}
