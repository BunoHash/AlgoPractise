using AlgoPractise.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise.SortAlgorithms
{
    public static class BubbleSort
    {
        private const string Name = "Bubble Sort";

        public static void StartBubbleSortProcess()
        {
            Console.WriteLine("##" + Name + "## ");
            var key = "y";
            while (key == "y")
            {
                IOManager.TakeNumberListInput();
                RunSorting();
                IOManager.ShowFinalNumberList();

                Console.WriteLine("Want to sort again? y/n");
                key = Console.ReadLine();
            }
        }

        private static void RunSorting()
        {
            var input = IOManager.Input;
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
                IOManager.ShowCurrentOutput();
            }


        }

        private static void Swap(int j)
        {
            var input = IOManager.Input;
            var cur = input[j];
            input[j] = input[j - 1];
            input[j - 1] = cur;
        }
    }
}
