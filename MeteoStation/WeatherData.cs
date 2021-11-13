using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoStation
{
    internal class WeatherData : ISubject
    {
        //private Displayer[] _displayers; //Tworząc pole tablicowe wymuszam na sobie inicjalizację tablicy o z góry ustalonej wielkości. Do poprawy.
        private List<IObserver> _observers;

        private float _humidity;
        private float _temperature;
        private float _pressure;    


        private void TakeHumidity(IObserver o) { }
        private void TakeTemp(IObserver o) { }
        private void TakePressure(IObserver o) { }


        public WeatherData()
        {
            this._observers = new List<IObserver>();            
        }

        public void RegisterObserver(IObserver o)
        {
            this._observers.Add(o);
        }
        public void DeleteObserver(IObserver o)
        {
            this._observers.Remove(o);
        }



        public void InformObserver()
        {

           
           foreach(var observer in this._observers)
            {
                observer.Actualize(_temperature, _humidity, _pressure);
            }


        }

        public void ReadingChange()
        {
            InformObserver();
        }

        public void SetReadings(float temp, float hum, float press)
        {
            this._temperature = temp;
            this._humidity = hum;
            this._pressure = press;
            ReadingChange();
        }

    }
}
