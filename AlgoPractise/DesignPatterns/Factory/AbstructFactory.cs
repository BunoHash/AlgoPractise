
using System;
using System.Collections.Generic;

public interface IHotDrink 
{
    void consume();

}

internal class Cofee : IHotDrink
{
    public void consume()
    {
        Console.WriteLine("Nice cofee");

    }
}

internal class Tea : IHotDrink
{
    public void consume()
    {
        Console.WriteLine("I had tea.");
    }
}

public interface IHotDrinkFactory
{
    IHotDrink prepare(int amount);
}

public class TeaFactory : IHotDrinkFactory
{
    public IHotDrink prepare(int amount)
    {
        Console.WriteLine($"{amount} of Tea consist of milk");
        return new Tea();
    }
}


public class CofeeFactory : IHotDrinkFactory
{
    public IHotDrink prepare(int amount)
    {
        Console.WriteLine($"{amount} of cofee grinned in mechine");
        return new Cofee();

    }
}




public class HotDrinkMechine
{
    public enum HotDrinkEnum
    {
        Tea,Cofee
    }


    private Dictionary<HotDrinkEnum, IHotDrinkFactory> factories = new Dictionary<HotDrinkEnum, IHotDrinkFactory>();


    public HotDrinkMechine()
    {
        foreach (HotDrinkEnum drink in Enum.GetValues(typeof(HotDrinkEnum)))
        {
            var factory = (IHotDrinkFactory)Activator.CreateInstance(
                Type.GetType(""+Enum.GetName(typeof(HotDrinkEnum), drink) +"Factory")
            );
            factories.Add(drink, factory);
        }
    }
    public IHotDrink MakeDrink(HotDrinkEnum drink, int amount)
    {
        var factory = factories[drink];
        return factory.prepare(amount);

    }



}


public class ExecuteAbsfactory
{
    public static void Run(){
        var mechine  = new HotDrinkMechine();
        var tea = mechine.MakeDrink(HotDrinkMechine.HotDrinkEnum.Tea, 200);
        var cofee = mechine.MakeDrink(HotDrinkMechine.HotDrinkEnum.Cofee, 150);

        Console.WriteLine(tea.ToString());
        Console.WriteLine(cofee.ToString());

    }


}





