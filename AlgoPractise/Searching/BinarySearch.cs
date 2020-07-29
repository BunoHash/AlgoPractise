using AlgoPractise.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise.Searching
{
    public static class BinarySearch
    {
        private const string Name = "Binary search";
        private static int Index = 0;

        public static void StartBiranySearchProcess()
        {
            Console.WriteLine("##" + Name + "## ");
            var key = "y";
            while (key == "y")
            {
                IOManager.TakeNumberListInput();
                IOManager.TakeSearchItemInput();
                RunSearching();
                

                Console.WriteLine("Want to search again? y/n");
                key = Console.ReadLine();
            }
        }

        

        private static void RunSearching()
        {
            DoBinarySearch();
            if (IOManager.Input[Index] == IOManager.SearchItem)
            {
                Console.WriteLine("Found at index : " + Index);
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
            
        }

        private static void DoBinarySearch()
        {
            var input = IOManager.Input;
            int searchItem = IOManager.SearchItem;
            int left = 0;
            int right = input.Count;

            while (left<right)
            {
                int mid = left + ((right - left) / 2);
                if (input[mid] > searchItem)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            Index = left;


        }
    }
}
