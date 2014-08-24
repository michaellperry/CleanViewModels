using Assisticant;
using Assisticant.Fields;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gotchas.Examples
{
    public class Circuit
    {
        private Observable<double> _battery = new Observable<double>();
        private Computed<double> _voltage1;

        private Resistor _resistor1;
        private Resistor _resistor2;
        private Resistor _resistor3;

        public Circuit()
        {
            _voltage1 = new Computed<double>(() =>
                _resistor1.Resistance *
                (_resistor2.Current + _resistor3.Current));

            _resistor1 = new Resistor(() => _voltage1);
            _resistor2 = new Resistor(() => _battery - _voltage1);
            _resistor3 = new Resistor(() => _battery - _voltage1);
        }

        public double Battery
        {
            get { return _battery; }
            set { _battery.Value = value; }
        }

        public double Voltage1
        {
            get { return _voltage1.Value; }
        }

        public Resistor Resistor1
        {
            get { return _resistor1; }
        }

        public Resistor Resistor2
        {
            get { return _resistor2; }
        }

        public Resistor Resistor3
        {
            get { return _resistor3; }
        }
    }
}
