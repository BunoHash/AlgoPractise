using System;

using DP.Creational.Singleton;

namespace DP.Creational.Singleton
{
    public class SingletonTester
    {
      public static bool IsSingleton(Func<object> func)
      {
        var obj1 = func();
        var obj2 = func();
        return ReferenceEquals(obj1, obj2);
      }
    }
  

 
  
    public class Singleton
    {
      
      public static void Test()
      {
        var obj = new object();
        var s1 = SingletonTester.IsSingleton(() => obj);
        var s2 = SingletonTester.IsSingleton(() => new object());

        Console.WriteLine(s1);
        Console.WriteLine(s2);
      }
    }

}

