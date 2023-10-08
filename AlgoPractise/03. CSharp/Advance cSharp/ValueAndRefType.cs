using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using WindowsForms_async_await.Models;

namespace CSharpOopPractise
{
    public static class ValueAndRefType
    {
        public static void RunTypePractise()
        {

            // class is Ref type : can decouple with deepclone :
            DerivedClass dc1 = new DerivedClass();
            dc1.Name = "dc1";
            DerivedClass dc2 = dc1;

            dc2.Name = "dc2";
            dc1.Name = "dc3";

            Console.WriteLine("a : " + dc1.Name);
            Console.WriteLine("b : " + dc2.Name);


            //int is value type don't hold ref :

            int a = 10;
            int b = a;

            a = 44;
            b = 9;

            Console.WriteLine("a : " +a);
            Console.WriteLine("b : " + b);


            //Strange : object type is refference type :
            // If int value changes because it's immutable
            object o1 = 12;
            object o2 = o1;

            o1 = 34;
            o2 = 56;

            Console.WriteLine("a : " + o1);
            Console.WriteLine("b : " + o2);

        }


        public static T DeepClone<T>(this T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
    }

   



}

