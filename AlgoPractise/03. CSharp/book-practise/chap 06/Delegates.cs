using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_async_await.book_practise.chap_06
{
    public class Delegates
    {
        delegate int Somemethods(string str);
        public static void Process()
        {
            Console.WriteLine(MethodIWantToCall("victor"));
            var diy = new Somemethods(MethodIWantToCall);
            var tt = MethodIWantToCall("rrt") + diy("123456");

            Console.WriteLine(tt);
        }

        public static int MethodIWantToCall(string input)
        {
            return input.Length;
        }
    }
}
