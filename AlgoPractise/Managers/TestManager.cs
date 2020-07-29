using System;
using System.Collections.Generic;
using System.Text;
using AlgoPractise.SortAlgorithms;

namespace AlgoPractise.NewFolder
{
    public static class TestManager
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

            return numbers; //= MargeArray(numbers, temp, leftStart, rightEnd);
        }

        

        public static void MargeArray()
        {

            int[] nums1 = {1, 2, 3, 0, 0, 0};
            int[] nums2 = {2, 5, 6};

            var leftEnd = 2;
            var rightEnd = 2;
            int left =0, right=0, index = 0;
            int[] temp = new int[nums1.Length];


            while (left <= leftEnd && right <= rightEnd)
            {
                if (nums1[left] < nums2[right])
                {
                    temp[index] = nums1[left];
                    left++;
                }
                else
                {
                    temp[index] = nums2[right];
                    right++;
                }
                index++;
            }

            for (int i = left; i <= leftEnd; i++)
            {
                temp[index++] = nums1[i];
            }

            for (int i = right; i <= rightEnd; i++)
            {
                temp[index++] = nums2[i];
            }

            nums1 = temp;

            foreach (var num in nums1)
            {
                Console.Write(num);
                Console.Write(" ");
            }

        }
    }
    
}
