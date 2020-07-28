using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise.SortAlgorithms
{
    public static class SelectionSort
    {
        public const string Name = "Selectio Sort";
        public static List<int> input { get; set; }

        public static void StartSelectionSortProcess()
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

        private static void RunSorting()
        {
            input = SortIOManager.Input;
            DoSelectionSort();

        }

        private static void DoSelectionSort()
        {
            int currentMin;
            int minIndex;
            int prevMinIndex =0;
            for (int i = 0; i < input.Count; i++)
            {
                currentMin = input[i];
                minIndex = i;
                for (int j = i+1; j < input.Count; j++)
                {
                    if (currentMin > input[j])
                    {
                        prevMinIndex = minIndex;
                        currentMin = input[j];
                        minIndex = j;
                    }
                }

                SwapItem(prevMinIndex, currentMin);
            }
        }
        private static void SwapItem(int left, int right)
        {
            var leftValue = input[left];
            input[left] = input[right];
            input[right] = leftValue;
        }


    }
}
