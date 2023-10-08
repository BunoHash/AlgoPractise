using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Oop
{

    public class Reflection
    {
        public static string Source = "https://www.youtube.com/watch?v=y8-uq6Ur7Dc";


        public void UseReflection()
        {
            Type type = Type.GetType("CSharp.Oop.Consumer");
            type = typeof(Consumer);

            Consumer con = new Consumer();
            type = con.GetType();

            PropertyInfo[] infos = type.GetProperties();
            
            MethodInfo[] methodInfos = type.GetMethods();
            ConstructorInfo[] constructorInfos = type.GetConstructors();

            Console.WriteLine("Assembly : "+ type.Assembly);
            Console.WriteLine("NameSpace : " + type.Namespace);
            Console.WriteLine("Class Full Name" + type.FullName);


            Console.WriteLine("\r\n Properties :");

            foreach (var info in infos)
            {
                Console.WriteLine(info.ToString());
            }

            Console.WriteLine("\r\n Methods :");

            foreach (var method in methodInfos)
            {
                Console.WriteLine(method.ToString());
            }



            Console.WriteLine("\r\n Constructors : ");

            foreach (var ctor in constructorInfos)
            {
                Console.WriteLine(ctor.ToString());
            }

            Console.ReadKey();


        }


    }


    public class Consumer
    {

        public Consumer()
        {
            this.random = new Random();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public static string Source { get; set; }


        private Random random;

        public string GetPurchaseHistory()
        {
            return "no history found";
        }

        public int GetAccountNo()
        {
            return 100 * (this.random.Next(1000));

        }
    }
}
