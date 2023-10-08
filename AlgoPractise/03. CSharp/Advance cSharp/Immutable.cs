using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_async_await.CSharp_OOP
{
    public class Immutable
    {
        private readonly string value;

        public Immutable(string valueParam)
        {
            value = valueParam;

        }

        public string GetValue()
        {
            return this.value;
        }
    }

    public enum Type
    {
        SuperShop = 0,
        Accessories = 1,
        Medicine = 2,
        Clothing = 4
    }


    public class Shop
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public Type ShopType { get; set; }

    }


    public class ImmutableShop
    {
        private readonly Shop Shwapno;

        public ImmutableShop(int id, string name, string address, Type shopType)
        {
            Shwapno.Id = id;
            Shwapno.Name = name;
            Shwapno.Address = address;
            Shwapno.ShopType = shopType;
        }

        public Shop Getvalue()
        {
            return Shwapno;
        }
    }

}
