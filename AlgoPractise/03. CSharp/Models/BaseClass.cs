using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_async_await.Models
{
    [Serializable]
    public class BaseClass
    {
        public string Name { get; set; }
        public int IndexofI { get; set; }

        public void PrintName()
        {
            System.Console.WriteLine(this.Name);
        }
    }

    [Serializable]
    public class DerivedClass : BaseClass
    {
        public string Name { get; set; }


    }
}
