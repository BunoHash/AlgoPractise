using System;
using System.Collections.Generic;
using System.Text;
using AlgoPractise.SortAlgorithms;

namespace AlgoPractise.NewFolder
{
    public static class Langu
    {
        static int n = 10;
        static int m = 20;
        static int a = n * m;

        public static void  ShowOutput()
        {
            for (int i = 2; i <= 100; i++)
            {

                Console.WriteLine(i*i);


            }

        }

        public static void RunSorting()
        {
            int[] numbers = {6,5,4,3,2,1};
            int[] temp= numbers;
            int leftStart = 0;
            int rightEnd = numbers.Length;
            int middle = rightEnd / 2;


            MargeSort(numbers, temp, leftStart, rightEnd);
        }

        private static int[] MargeSort(int[] numbers, int[] temp, int leftStart, int rightEnd)
        {
            int middle = (leftStart + rightEnd) / 2;
            numbers = MargeSort(numbers, temp, leftStart, middle);
            numbers = MargeSort(numbers, temp, middle+1, rightEnd);

            return numbers = MargeArray(numbers, temp, leftStart, rightEnd);
        }

        private static int[] MargeArray(int[] numbers, int[] temp, int leftStart, int rightEnd)
        {
            int middle = (leftStart + rightEnd) / 2;
            int leftEnd = middle;
            int rightStart = middle + 1;
            int left = leftStart;
            int right = rightStart;
            int index = leftStart;
            

            while (left<= leftEnd && right<= rightEnd)
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

            for (int i = leftStart; i <= rightEnd; i++)
            {
                numbers[i] = temp[i];
            }

            return numbers;
        }
    }
}
