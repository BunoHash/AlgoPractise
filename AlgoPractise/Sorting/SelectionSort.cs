using AlgoPractise.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise.SortAlgorithms
{
    public static class SelectionSort
    {
        private const string Name = "Selectio Sort";
        private static List<int> input { get; set; }

        public static void StartSelectionSortProcess()
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
            input = IOManager.Input;
            DoSelectionSort();

        }

        private static void DoSelectionSort()
        {
            int currentMin;
            int minIndex;
            int prevMinIndex =0;
            for (int i = 0; i < input.Count-1; i++)
            {
                currentMin = input[i];
                minIndex = i;
                for (int j = i+1; j < input.Count; j++)
                {
                    if (input[j] > input[minIndex])
                    {
                        prevMinIndex = minIndex;
                        currentMin = input[j];
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    SwapItem(i, minIndex);
                }
                IOManager.ShowCurrentOutput();
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
  