﻿using Assisticant;
using Assisticant.Fields;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gotchas.Examples
{
    public class Circuit
    {
        private Observable<double> _battery = new Observable<double>();
        private Observable<double> _voltage1 = new Observable<double>();

        private Resistor _resistor1;
        private Resistor _resistor2;
        private Resistor _resistor3;

        public Circuit()
        {
            _resistor1 = new Resistor(() => _voltage1);
            _resistor2 = new Resistor(() => _battery - _voltage1);
            _resistor3 = new Resistor(() => _battery - _voltage1);
        }

        public void Compute()
        {
            _voltage1.Value = _battery / 2.0;

            while (true)
            {
                var nextVoltage1 =
                    _resistor1.Resistance *
                    (_resistor2.Current + _resistor3.Current);

                if (Math.Abs(_voltage1 - nextVoltage1) < 0.00001)
                    break;

                _voltage1.Value = (_voltage1 + nextVoltage1) / 2.0;
            }
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
