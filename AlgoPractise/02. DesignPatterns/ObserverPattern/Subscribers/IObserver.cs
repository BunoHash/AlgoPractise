using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractise._02._DesignPatterns.ObserverPattern
{
    internal interface IObserver
    {
        void Update(int temperature, int windSpeed, int pressure);
    }
}
