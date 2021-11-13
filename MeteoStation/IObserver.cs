using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoStation
{
    internal interface IObserver
    {
        public abstract void Actualize(float temp, float hum, float press);
    }
}
