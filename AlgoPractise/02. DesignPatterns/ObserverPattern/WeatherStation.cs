using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPractise._02._DesignPatterns.ObserverPattern
{
    internal class WeatherStation : ISubject
    {
        private readonly List<IObserver> _subscribers;
        private int _temperature;
        private int _windSpeed;
        private int _pressure;

        public WeatherStation()
        {
            _subscribers = new List<IObserver>();
        }

        public void Notify()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(_temperature, _windSpeed, _pressure);
            }
        }

        public void setTemperature(int temp)
        {
            this._temperature = temp;
            Notify();
        }

        public void setWindSpeed(int temp)
        {
            this._temperature = temp;
            Notify();
        }

        public void setPressure(int temp)
        {
            this._temperature = temp;
            Notify();
        }


        public void RegisterObserver(IObserver observer)
        {
            _subscribers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _subscribers.Remove(observer);
        }
    }
}
