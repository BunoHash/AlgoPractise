using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractise._04._AlgorithmDS.CondinInterview_Subeen
{
    internal  static class HotelBookingsPossible
    {

        private static int[] cheackIns = new int[] { 3, 1, 5 };
        private static int[] cheackouts = new int[] { 8, 6, 2 };
        static int len = cheackIns.Length;
        
        

        public static void IsPossible()
        {
            int i = 0, j = 0, bookingCount = 0,maxRoom =1;
            Array.Sort(cheackIns);
            Array.Sort(cheackouts);
            while (i<len && j<len)
            {
                if (cheackIns[i] < cheackouts[j])
                {
                    bookingCount++; i++;
                    if (bookingCount > maxRoom){ Console.WriteLine("OverBooked");  return; }
                }
                else
                {
                    j++;
                    bookingCount--;
                }
            }

            Console.WriteLine("Bokking Success");
        }
    }
}
