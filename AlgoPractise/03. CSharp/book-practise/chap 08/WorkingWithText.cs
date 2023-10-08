using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_async_await.book_practise.chap_08
{
    public class WorkingWithText
    {
        public static void Test()
        {
            string city = "Dhaka";
            Console.WriteLine($"City is {city.Length} character long");
            Console.WriteLine(city.Substring(3));

            string name = "Ken Anderson";
            int spaceIndex = name.IndexOf(' ');
            string firstName = name.Substring(0, spaceIndex);
            string lastName = name.Substring(spaceIndex);

            Console.WriteLine($"Last name: {lastName}, FirstName : {firstName}");


        
        }
    }
}
