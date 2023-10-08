// You are given an array with zeroes, ones and twos. 
// Sort the same array arr in place and return it, do not create a new array. Solve it in O(n) complexity
// INPUT: N- size of array, arr - the array itself.



using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise._04._AlgorithmDS.Sorting.Problems
{
    public static class SortItUp
    {
        
        public static int[] Solve()
        {
            int[] input = { 0, 1, 1, 2, 1, 2, 1, 0, 0, 1, 2, 1, 0 };
            int leftBoundary = 0, rightBoundary=input.Length-1, current =0;

            while (current < rightBoundary) {
                if (input[current] == 0) 
                {
                    input[current] = input[leftBoundary];
                    input[leftBoundary] = 0;
                    current++;leftBoundary++;
                }
                if (input[current] == 2) 
                {
                    input[current] = input[rightBoundary];
                    input[rightBoundary] = 2;
                    rightBoundary--;

                }
                if (input[current] == 1) 
                {
                    current++;
                }
            
            }


            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(string.Format(" {0}", input[i]));
            }
            Console.WriteLine();

            return new int[] { 0, 0, 0, 0, 0 };
        }

    }
}
