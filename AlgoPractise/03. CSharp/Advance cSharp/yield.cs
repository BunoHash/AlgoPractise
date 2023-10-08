using System;
using System.Collections.Generic;

public class TestYield

{
    public List<int> MyList;
    public void RunProcess(){

        List<int> temp = new List<int>();
        Fillvalues();
        
        foreach (var item in Filter())
        {
            Console.WriteLine(item);
        }
    }

    void  Fillvalues()
    {
        MyList = new List<int>();
        MyList.Add(1);       
        MyList.Add(2);       
        MyList.Add(3);       
        MyList.Add(4);       
        MyList.Add(5);       

    }

    public IEnumerable<int> Filter()
    {

        foreach (var item in MyList)
        {
            if(item<4) yield return item;
        }
    }
        

}