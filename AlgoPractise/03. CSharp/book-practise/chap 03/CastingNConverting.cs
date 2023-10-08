using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_async_await.book_practise.chap_03
{
    public static class CastingNConverting
    {
        public static void Casting()
        {
            int a = 10;
            double b = a; // an int can be safely cast into a double
            Console.WriteLine(b);

            double c = 9.8;
            int d = (int)c;
            Console.WriteLine(d); // d is 9 losing the .8 part

            long e = 10;
            int f = (int)e;
            Console.WriteLine($"e is {e:N0} and f is {f:N0}");

            e = 5_000_000_000;
            f = (int)e;
            Console.WriteLine($"e is {e:N0} and f is {f:N0}");

            double g = 9.8;
            int h = Convert.ToInt32(g);
            Console.WriteLine($"g is {g} and h is {h}");

            // Understanding the default rounding rules

            double[] doubles = new[]
              { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

            foreach (double n in doubles)
            {
                Console.WriteLine($"ToInt32({n}) is {Convert.ToInt32(n)}");
            }

            // Taking control of rounding rules

            foreach (double n in doubles)
            {
                Console.WriteLine(format:
                  "Math.Round(value: {0}, digits: 0, mode: MidpointRounding.AwayFromZero) is {1}",
                  arg0: n,
                  arg1: Math.Round(value: n,
                    digits: 0,
                    mode: MidpointRounding.AwayFromZero));
            }

            // Converting from any type to a string

            int number = 12;
            Console.WriteLine(number.ToString());

            bool boolean = true;
            Console.WriteLine(boolean.ToString());

            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());

            object me = new object();
            Console.WriteLine(me.ToString());

            // allocate array of 128 bytes 
            byte[] binaryObject = new byte[128];

            // populate array with random bytes 
            (new Random()).NextBytes(binaryObject);

            Console.WriteLine("Binary Object as bytes:");

            for (int index = 0; index < binaryObject.Length; index++)
            {
                Console.Write($"{binaryObject[index]:X} ");
            }
            Console.WriteLine();

            // convert to Base64 string and output as text
            string encoded = Convert.ToBase64String(binaryObject);
            Console.WriteLine($"Binary Object as Base64: {encoded}");

            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1980");

            Console.WriteLine($"I was born {age} years ago.");
            Console.WriteLine($"My birthday is {birthday}.");
            Console.WriteLine($"My birthday is {birthday:D}.");

            Console.Write("How many eggs are there? ");
            int count;
            string input = Console.ReadLine();
            if (int.TryParse(input, out count))
            {
                Console.WriteLine($"There are {count} eggs.");
            }
            else
            {
                Console.WriteLine("I could not parse the input.");
            }
        }
    }
}
