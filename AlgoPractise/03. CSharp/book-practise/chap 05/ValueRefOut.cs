using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_async_await.book_practise.chap_05
{
    public class ValueRefOut
    {
        public static void TestParamsType()
        {
            int x= 10, y = 20, z = 30;
            Console.WriteLine(String.Format("Values x: {0}, y: {1}, z : {2}", x, y, z));
            Increment(x,ref y,out z);
            Console.WriteLine(String.Format("After value changes: "));
            Console.WriteLine(String.Format("Values x: {0}, y: {1}, z : {2}", x, y, z));



        }


        private static void Increment(int a, ref int b,out int c){
            a++;  b++; c = 99;  c++;
        }
    }
}
