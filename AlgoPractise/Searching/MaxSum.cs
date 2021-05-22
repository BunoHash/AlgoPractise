using AlgoPractise.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise.Searching
{
    public class MaxSum
    {
        private const string Name = "Maximum Sum";
        private static int Index = 0;

        public static void StartBiranySearchProcess()
        {
            Console.WriteLine("##" + Name + "## ");
            var key = "y";
            while (key == "y")
            {
                IOManager.TakeNumberListInput();
                IOManager.TakeSearchItemInput();
                RunMaxSum();


                Console.WriteLine("Want to search again? y/n");
                key = Console.ReadLine();
            }
        }

        private static int RunMaxSum()
        {

            var input = IOManager.Input;
            int maxEndingHere = 0;
            int maxSofar = int.MinValue;


            for (int i = 0; i < input.Count; i++)
            {
                maxEndingHere += input[i];

                if (maxEndingHere > maxSofar)
                {
                    maxSofar = maxEndingHere;
                }

                if (maxEndingHere < 0)
                {
                    maxEndingHere = 0;
                }


            }


            return maxSofar;

        }
    }
}
