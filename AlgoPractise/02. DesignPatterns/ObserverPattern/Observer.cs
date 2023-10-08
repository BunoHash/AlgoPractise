using AlgoPractise._02._DesignPatterns.ObserverPattern.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractise._02._DesignPatterns.ObserverPattern
{
    internal static class Observer
    {
        public static void Run()
        {
            var weatherStation = new WeatherStation();
            weatherStation.RegisterObserver(new Logger());
            weatherStation.RegisterObserver(new AlertSystem());
            weatherStation.RegisterObserver(new Logger());

            weatherStation.setPressure(12);
            weatherStation.setTemperature(12);

        }
    }
}
