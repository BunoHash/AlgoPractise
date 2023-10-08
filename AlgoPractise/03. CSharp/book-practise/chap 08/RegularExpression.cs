using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsForms_async_await.book_practise.chap_08
{
    public class RegularExpressionTest
    {
        public static void Test()
        {
            Console.WriteLine("Enter your age");
            var ageChecker = new Regex(@"^\d+$");
            string input = Console.ReadLine();

            while (ageChecker.IsMatch(input))
            {
                Console.WriteLine($"Your age is {input}");
                Console.WriteLine("Enter your age");
                input = Console.ReadLine();

            }
            Console.WriteLine("Invalid age");


        }
    }
}
