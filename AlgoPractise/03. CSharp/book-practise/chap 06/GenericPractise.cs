using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsForms_async_await.book_practise.chap_06
{


    public class GenericThing<T> where T : IComparable
    {
        public T Data = default(T);
        public void Process(T input)
        {
            if (Data.CompareTo(input)==0)
            {
                Console.WriteLine("same");
            }
            else Console.WriteLine("not same");
        }


    }

    public class SquareMaker
    {
        public static double Square<T>(T input) where T : IConvertible
        {
            var d = input.ToDouble(Thread.CurrentThread.CurrentCulture);
            return d*d;
        }
    }
    public class GenericPractise
    {
        public static void Process()
        {
            var gt1 = new GenericThing<int>();
            gt1.Data = 90;
            gt1.Process(90);

            SquareMaker.Square<int>(45);

           // var gt2 = new GenericThing<string>;

         
        }
    }
}
