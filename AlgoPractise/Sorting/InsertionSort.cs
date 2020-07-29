using AlgoPractise.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise.SortAlgorithms
{
    public static class InsertionSort
    {
        public const string Name = "Insertion Sort";
        public static void StartInsertionSortProcess()
        {
            Console.WriteLine("##"+ Name + "## ");
            var key = "y";
            while (key=="y")
            {
                
                IOManager.TakeNumberListInput();
                RunSorting();
                Console.WriteLine("Final Output: ");
                IOManager.ShowCurrentOutput();

                Console.WriteLine("Want to sort again? y/n");
                key = Console.ReadLine();
            }
            

        }
        private static void RunSorting()
        {
            var input = IOManager.Input;

            Console.WriteLine("Start sorting : ");
            Console.ReadKey();
            for (int i = 1; i < input.Count; i++)
            {
                var current = input[i];
                int j = i-1 ;
                while (j >= 0 && input[j] > current)
                {
                    input[j+1] = input[j];
                    j--;
                }
                input[j+1] = current;
                IOManager.ShowCurrentOutput();
            }
        }

    }
}
