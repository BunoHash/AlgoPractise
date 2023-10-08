using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractise._05._Problem_Solving
{
    internal static class MaxSumContiguousSubarray
    {
        static int[] input = { -1, -2, 1, 2, 3, -5, 4, -3, 4, 0, -23 };

        internal static void FindMaxSum()
        {
            int currentSum = 0, maxSum = int.MinValue;
            for(int i = 0; i < input.Length; i++)
            {
                currentSum += input[i];
                if(currentSum > maxSum) maxSum = currentSum; 
                if(currentSum<0) currentSum = 0;

            }

            Console.WriteLine(maxSum);
        }


    }
}
