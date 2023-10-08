using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_async_await.book_practise.chap_03
{
    public static class Operator
    {
        public static void bitwise()
        {
            int a = 10; // 0000 1010
            int b = 6;  // 0000 0110

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"a & b = {a & b}"); // 2-bit column only
            Console.WriteLine($"a | b = {a | b}"); // 8, 4, and 2-bit columns
            Console.WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit columns

            // 0101 0000 left-shift a by three bit columns
            Console.WriteLine($"a << 3 = {a << 3}");

            // multiply a by 8
            Console.WriteLine($"a * 8 = {a * 8}");

            // 0000 0011 right-shift b by one bit column
            Console.WriteLine($"b >> 1 = {b >> 1}");


        }

        public static void Logical()
        {
            bool a = true;
            bool b = false;

            Console.WriteLine($"AND  | a     | b    ");
            Console.WriteLine($"a    | {a & a,-5} | {a & b,-5} ");
            Console.WriteLine($"b    | {b & a,-5} | {b & b,-5} ");
            Console.WriteLine();
            Console.WriteLine($"OR   | a     | b    ");
            Console.WriteLine($"a    | {a | a,-5} | {a | b,-5} ");
            Console.WriteLine($"b    | {b | a,-5} | {b | b,-5} ");
            Console.WriteLine();
            Console.WriteLine($"XOR  | a     | b    ");
            Console.WriteLine($"a    | {a ^ a,-5} | {a ^ b,-5} ");
            Console.WriteLine($"b    | {b ^ a,-5} | {b ^ b,-5} ");

            Console.WriteLine($"a && DoStuff() = {a && true}");
            Console.WriteLine($"b && DoStuff() = {b && false}");

            object obj = 3;
            int j = 4;
            if(obj is int i)
            {
                Console.WriteLine($"{i} *{j} = {i * j}");

            }
        }
    }
}
