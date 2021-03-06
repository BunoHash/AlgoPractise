﻿using AlgoPractise.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise.SortAlgorithms
{
    public class QuickSort
    {
        private const string Name = "Quick Sort";
        private static List<int> input { get; set; }
        public static void StartQuickSortProcess()
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

            Environment.Exit(1);
        }

        private static void RunSorting()
        {
            input = IOManager.Input;
            DoQuickSort(0, input.Count-1);

        }

        private static void DoQuickSort( int left, int right)
        {
            if(left>=right) return;

            int pIn = (left + right) / 2;
            int pivot = input[pIn];

            var index = Pertition( left, right, pivot);

            DoQuickSort( left, index-1);
            DoQuickSort( index, right);
            IOManager.ShowCurrentOutput();
        }

        private static int Pertition(int left, int right, int pivot)
        {
            while (left<=right)
            {
                while (input[left]<pivot)
                {
                    left++;
                }

                while (input[right]>pivot)
                {
                    right--;
                }

                if (left <= right)
                {
                    SwapItem(left, right);
                    left++;
                    right--;
                }

            }

            return left;
        }

        private static void SwapItem(int left, int right)
        {
            var leftValue = input[left];
            input[left] = input[right];
            input[right] = leftValue;
        }
    }
}
