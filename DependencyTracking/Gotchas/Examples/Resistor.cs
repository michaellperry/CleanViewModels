using Assisticant.Fields;
using System;

namespace Gotchas.Examples
{
    public class Resistor
    {
        private Func<double> _voltageDrop;
        private Observable<double> _resistance = new Observable<double>();
        private Computed<double> _current;

        public Resistor(Func<double> voltageDrop)
        {
            _voltageDrop = voltageDrop;

            _current = new Computed<double>(() =>
                _voltageDrop() / _resistance);
        }

        public double Resistance
        {
            get { return _resistance; }
            set { _resistance.Value = value; }
        }

        public double Current
        {
            get { return _current.Value; }
        }
    }
}
