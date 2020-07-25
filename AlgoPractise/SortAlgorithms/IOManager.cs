using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise.SortAlgorithms
{
    public static class IOManager
    {
        internal static List<int> Input { get; set; }
        internal static List<int> Output { get; set; }

        public static void ProcessInput()
        {

            Input = new List<int>();

            Console.WriteLine("Insert '/' when finished. Insert numbers :");
            var readKey = Console.ReadLine();

            while (readKey!= "/")
            {
                var isNumeric = int.TryParse(readKey, out int n);
                if (isNumeric)
                {
                    var number = Convert.ToInt32(readKey);
                    Input.Add(number);
                    readKey = Console.ReadLine();
                }
                
            }

            Console.WriteLine("Unsorted list :");
            for (int i = 0; i < Input.Count; i++)
            {
                Console.Write(Input[i].ToString() + " ");
            }

            Console.WriteLine("\r\n");

        }

        

        public static void ShowCurrentOutput()
        {
            Console.WriteLine("Current Output : ");
            for (int i = 0; i < Input.Count; i++)
            {
                Console.Write(Input[i].ToString() + " ");
            }

            Console.WriteLine("\r\n");
        }

        internal static void ShowFinalOutput()
        {
            Console.WriteLine("Final Output:");
            ShowCurrentOutput();
        }
    }
}
