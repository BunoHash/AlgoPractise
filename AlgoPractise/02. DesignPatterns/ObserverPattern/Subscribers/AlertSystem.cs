using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractise._02._DesignPatterns.ObserverPattern.Subscribers
{
    internal class AlertSystem : IObserver
    {
        public void Update(int temperature, int windSpeed, int pressure)
        {
            Console.WriteLine($"Alert updated with temp: {temperature}, wind: {windSpeed}km/hr & pressure: {pressure}");

        }
    }
}
