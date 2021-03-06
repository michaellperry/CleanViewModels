﻿using Assisticant.Fields;
using System;

namespace Gotchas.Examples
{
    public class LoanCalculator
    {
        // T = P (1 + r/n)^(nt)
        // T = Total
        // P = Principal
        // r = Interest rate
        // n = Periods per year (12)
        // t = Number of years

        // ln(T) = nt ln(P (1 + r/n))
        // t = ln(T) / [n ln(P (1 + r/n))]
        private Observable<double> _principal = new Observable<double>();
        private Observable<double> _rate = new Observable<double>();
        private Observable<double> _obsTotal = new Observable<double>(default(double));
        private Observable<double> _obsTime = new Observable<double>(default(double));
        private Observable<bool> _useTime = new Observable<bool>();
        private Computed<double> _total;
        private Computed<double> _time;
        private const double _periods = 12;

        public LoanCalculator()
        {
            _total = new Computed<double>(() => _useTime ?
                _principal * Math.Pow(
                    1.0 + _rate / _periods,
                    _periods * _time) :
                _obsTotal
            );
            _time = new Computed<double>(() => _useTime ?
                _obsTime :
                Math.Log(_total) /
                (_rate * Math.Log(_principal *
                    (1.0 + _rate / _periods)))
            );
        }

        public double Principal
        {
            get { return _principal; }
            set { _principal.Value = value; }
        }

        public double Rate
        {
            get { return _rate; }
            set { _rate.Value = value; }
        }

        public double Total
        {
            get { return _total.Value; }
            set
            {
                _obsTotal.Value = value;
                _useTime.Value = false;
            }
        }

        public double Time
        {
            get { return _time.Value; }
            set
            {
                _obsTime.Value = value;
                _useTime.Value = true;
            }
        }
    }
}
