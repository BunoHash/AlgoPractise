using System;
using System.Collections.Generic;


namespace DP.Creational.Singleton
{

    public interface IDatabase
    {
        int Getpopulation(string name);
    }


    public class SingletonDatabase : IDatabase
    {
        private Dictionary<string, int> capitals;

        private SingletonDatabase()
        {
            Console.WriteLine("Init Singleton sDb");
            capitals = new Dictionary<string, int>();
            capitals.Add("Jakarta", 2000);
            capitals.Add("Dhaka", 20009);
            capitals.Add("bangkok", 200056);
        }

        public int Getpopulation(string name)
        {
            return capitals[name];
        }
        private static Lazy<SingletonDatabase> instance =>  new Lazy<SingletonDatabase>(()=> new SingletonDatabase());
        public static SingletonDatabase _dbContext = instance.Value;
    }


    public class ExecuteSingleton{

        public static void Run(){

        var db = SingletonDatabase._dbContext;
            Console.WriteLine(db.Getpopulation("Dhaka"));
            var db1 = SingletonDatabase._dbContext;
            var db2 = SingletonDatabase._dbContext;
            Console.WriteLine(db2.Getpopulation("Jakarta"));
        }
    }

}