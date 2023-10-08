using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Drinks
    {

    }

    internal class SoftDrinks : Drinks
    {

    }
    internal class Pepsi : SoftDrinks
    {

    }


    public static class Inheritance
    {
        public static void Show()
        {
            SoftDrinks bottleDrinks = new SoftDrinks();

            if (bottleDrinks is SoftDrinks) Console.WriteLine("Type SoftDrinks");
            if (bottleDrinks is Drinks) Console.WriteLine("Type Drinks");
            if (bottleDrinks is Pepsi) Console.WriteLine("Type Pepsi");
        }
    }
}
