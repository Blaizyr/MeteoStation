using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoStation
{
    internal class ModuleStats : IModule, IObserver
    {
        public void Actualize(float temp, float hum, float press)
        {

        }
        void IModule.Display()
        {
            Console.WriteLine("Weather Statistics \n");
        }
    }
}
