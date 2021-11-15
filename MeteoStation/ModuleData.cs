using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoStation
{
    internal class ModuleData : IModule, IObserver
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private ISubject _weatherData;

        public ModuleData(ISubject weatherData)
        {
            this._weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Actualize(float temp, float hum, float press)
        {
            _temperature = temp;
            _humidity = hum;
            _pressure = press;

            Display();
        }

        public void Display()
        {
            Console.Write("Informacje pogodowe: \n" + "Temperatura: {0} stopni Celsjusza. \n" + "Wilgotność powietrza: {1}% \n" + "Ciśnienie astmosferyczne: {2} hPa \n", _temperature, _humidity, _pressure );
        }
    }
}
