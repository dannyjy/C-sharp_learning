using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPP.Encapsulation
{
    public class Thermostat
    {
        private double _temperature;
        public double Temperature
        {
            get { return _temperature; }
            set
            {
                if(value < 0) value = 21;
                _temperature = value;
            }
        }
    }
}