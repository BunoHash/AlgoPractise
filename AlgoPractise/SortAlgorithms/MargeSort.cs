using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoPractise.SortAlgorithms
{
    public static class MargeSort
    {
        public static string Name = "Marge Sort";
        public static void StartMargeSortProcess()
        {
            Console.WriteLine("##" + Name + "## ");
            var key = "y";
            while (key == "y")
            {

                IOManager.ProcessInput();
                RunSorting();
               
                IOManager.ShowFinalOutput();

                Console.WriteLine("Want to sort again? y/n");
                key = Console.ReadLine();
            }
        }

        public static void RunSorting()
        {

            var input = IOManager.Input;
            var temp = input.ToList();
            DoMargeSort(input, temp, 0 , input.Count-1);
            
        }

        private static List<int> DoMargeSort(List<int> numbers, List<int>temp, int leftStart, int rightEnd)
        {
            IOManager.ShowCurrentOutput();

            if (leftStart>=rightEnd)return numbers;
            int middle = (leftStart + rightEnd) / 2;
            numbers = DoMargeSort(numbers, temp, leftStart, middle);
            numbers = DoMargeSort(numbers, temp, middle+1, rightEnd);

            numbers = MargeHalves(numbers, temp, leftStart, rightEnd);
            return numbers;

        }

        private static List<int> MargeHalves(List<int> numbers, List<int> temp, int leftStart, int rightEnd)
        {
            int leftEnd = (leftStart + rightEnd) / 2;
            int rightStart = leftEnd + 1;
            int size = (rightEnd - leftStart) + 1;

            int left = leftStart;
            int right = rightStart;
            int index = leftStart;

            while (left <= leftEnd && right <= rightEnd)
            {
                if (numbers[left] < numbers[right])
                {
                    temp[index] = numbers[left];
                    left++;
                }
                else
                {
                    temp[index] = numbers[right];
                    right++;
                }

                index++;
            }
            
            // copy rest of the left and right array
            for (int i = left; i <= leftEnd; i++)
            {
                temp[index] = numbers[i];
                index++;
            }
            for (int i = right; i <= rightEnd; i++)
            {
                temp[index] = numbers[i];
                index++;
            }
            //index = leftStart;
            for (int i = leftStart; i <= rightEnd; i++)
            {
                numbers[i] = temp[i];

            }

            return numbers;
        }

    }
}
