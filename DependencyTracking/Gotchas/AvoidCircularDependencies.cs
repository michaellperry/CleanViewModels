using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gotchas.Examples;
using Assisticant.Fields;

namespace Gotchas
{
    [TestClass]
    public class AvoidCircularDependencies
    {
        [TestMethod]
        public void CanComputeLoan()
        {
            var loan = new LoanCalculator();
            loan.Principal = 1000.0;
            loan.Rate = 0.08;
            //loan.Time = 5;

            var total = loan.Total;

            Assert.AreEqual(1100.0, total);
        }

        [TestMethod]
        public void CanComputeCurcuit()
        {
            var circuit = new Circuit();
            circuit.Battery = 5.0;

            circuit.Resistor1.Resistance = 30.0;
            circuit.Resistor2.Resistance = 50.0;
            circuit.Resistor3.Resistance = 100.0;

            Assert.AreEqual(0.3, circuit.Voltage1);
        }
    }
}
