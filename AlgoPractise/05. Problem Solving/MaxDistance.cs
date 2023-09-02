//Interview Prep. Subeen: chap 3/ Max Distance
// Find the max value of j-i, where arr[j]>= arr[i] & j>=i

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractise._05._Problem_Solving
{
    internal  static class MaxDistance
    {
        static int[] nums = {4,2,9,0,1,2,3,8,3,0};
       
        internal static void FindDistancse()
        {
            List<Tuple<int,int>> indexValuePair = new List<Tuple<int,int>>();
            int maxDistance = 1, currentDistance = 0;
            // sort the array with index number: learn dis with nlogN complexity later with modified version, than this will be solved.
            // the find the max index distance.
            // this is a trivial approach for now only:

            for (int i = 0; i < nums.Length; i++)
            {
                indexValuePair.Add(new Tuple<int, int>(nums[i], i));
            }

            indexValuePair.Sort();


            for(int i=1;i<indexValuePair.Count; i++)
            {
                var item = indexValuePair[i].Item2;
                var lastItem = indexValuePair[i-1].Item2;
                if (item >= lastItem)
                {
                    currentDistance = item - lastItem + currentDistance;
                    maxDistance = Math.Max(maxDistance, currentDistance);
                }
                else currentDistance = 0;
            }

            Console.WriteLine(maxDistance);
        }


    }
}
