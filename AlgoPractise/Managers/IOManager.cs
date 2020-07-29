using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoPractise.Managers
{
    public static class IOManager
    {
        public static List<int> Input { get; set; }
        public static List<int> Output { get; set; }
        public static int SearchItem { get; set; }

        public static void TakeNumberListInput()
        {

            Input = new List<int>();

            Console.WriteLine("Insert '/' when finished. Insert numbers :");
            var readKey = Console.ReadLine();

            while (readKey != "/")
            {
                var isNumeric = int.TryParse(readKey, out int n);
                if (isNumeric)
                {
                    var number = Convert.ToInt32(readKey);
                    Input.Add(number);
                }
                readKey = Console.ReadLine();
            }

            Console.WriteLine("Initial list :");
            for (int i = 0; i < Input.Count; i++)
            {
                Console.Write(Input[i].ToString() + " ");
            }

            Console.WriteLine("\r\n");

        }

        internal static void TakeSearchItemInput()
        {
            Console.WriteLine("Insert the number to search :");
            var readKey = Console.ReadLine();
            var isNumeric = int.TryParse(readKey, out int n);
            if (isNumeric)
            {

                SearchItem = Convert.ToInt32(readKey);
            }
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

        public static void ShowFinalNumberList()
        {
            Console.WriteLine("Final Output:");
            for (int i = 0; i < Input.Count; i++)
            {
                Console.Write(Input[i].ToString() + " ");
            }

            Console.WriteLine("\r\n");
        }
    }
}
