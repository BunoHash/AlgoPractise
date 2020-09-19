
using System;


namespace DP.Creational.Singleton
    {
    public class CEO
    {
        private static string name;
        private static int age;

        public string Name
        {
            get=> name;
            set=> name = value;

        }

        public int Age
        {
            get=> age;
            set=>age= value;

        }

        public override string ToString()
        {
            return ($"Name : {this.Name}, Age: {this.Age}");
        }

    }





    public class MonoState{
        public static void Run(){

            var ceo1  = new CEO();
            ceo1.Name = "Adam Smith";
            ceo1.Age = 34;

            var ceo2 = new CEO();
            ceo2.Name = "Hogu Mira";

            Console.WriteLine(ceo1);
            Console.WriteLine(ceo1);

        }
    }

}