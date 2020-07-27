using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise.SortAlgorithms
{
    public static class BubbleSort
    {
        public static string Name = "Bubble Sort";

        public static void StartBubbleSortProcess()
        {
            Console.WriteLine("##" + Name + "## ");
            var key = "y";
            while (key == "y")
            {
                SortIOManager.ProcessInput();
                RunSorting();
                SortIOManager.ShowFinalOutput();

                Console.WriteLine("Want to sort again? y/n");
                key = Console.ReadLine();
            }
        }

        public static void RunSorting()
        {
            var input = SortIOManager.Input;
            bool isSorted;

            for (int i = 0; i < input.Count; i++)
            {
                isSorted = true;
                for (int j = 1; j < input.Count-i; j++)
                {
                    if (input[j] < input[j -1])
                    {
                        Swap(j);
                        isSorted = false;
                    }
                }
                if(isSorted) return;
                SortIOManager.ShowCurrentOutput();
            }


        }

        private static void Swap(int j)
        {
            var input = SortIOManager.Input;
            var cur = input[j];
            input[j] = input[j - 1];
            input[j - 1] = cur;
        }
    }
}
