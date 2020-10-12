using System;

public class TestDelegate
{


    public void Run()
    {
        Myclass obj = new Myclass();
        obj.LNRun(Callback);

        SomeMethodPtr ptr = new SomeMethodPtr(SomeMethod);
        
        //ptr.Invoke();
    }


    void Callback(int i)
    {
        Console.WriteLine(i);
    }
    
    public class Myclass
    {
        public delegate void CallBack(int i);
        public void LNRun(CallBack obj)
        {
            for(int i=0;i<100;i++){
                //
                obj(i);
            }
        }

    }


    public delegate void SomeMethodPtr();
    static void SomeMethod()
    {
        Console.WriteLine("SM Called");

    }


}