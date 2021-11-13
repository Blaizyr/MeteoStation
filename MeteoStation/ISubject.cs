using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoStation
{
    internal interface ISubject
    {
        public abstract void RegisterObserver(IObserver o); //Dlaczego w metodzie abstrakcyjnej muszę podać typ argumentu?
        public void DeleteObserver(IObserver o);
        public abstract void InformObserver();
    }
}
