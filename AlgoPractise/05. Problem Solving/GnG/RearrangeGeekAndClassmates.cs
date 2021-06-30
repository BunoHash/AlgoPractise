using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise._05._DataStructure_And_Problem_Solving.GnG
{
    public class RearrangeGeekAndClassmates
    {
        /// <summary>
        /// Problem Link : https://practice.geeksforgeeks.org/tracks/30-DOC-day-1/?batchId=320
        /// After login to geeks for geeks
        /// </summary>

        public void Rearrange(long [] a, int n)
        {
            int len = n;
            int checke = 0, index = 0;
            long[] temp = new long[n];
            long tempData, data;
            for (int i = 0; i < len; i++)
            {
                temp[a[i]] = i;
            }


            long prevIndex = 0, newIndex = -1;
            while (checke < len && prevIndex < n)
            {

                data = a[prevIndex];
                //tempData = temp[prevIndex]
                while (data != prevIndex && checke < len)
                {

                    newIndex = temp[prevIndex];
                    if (newIndex < 0) break;
                    temp[prevIndex] = -1;
                    tempData = a[newIndex];
                    a[newIndex] = data;
                    data = tempData;
                    prevIndex = newIndex;
                    checke++;

                }
                if (newIndex > -1)
                {
                    checke++;
                }
                prevIndex++;



            }
        }
    }
}
