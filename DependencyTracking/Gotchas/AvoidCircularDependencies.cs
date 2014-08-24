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
            loan.Time = 5;

            var total = loan.Total;

            Assert.AreEqual(1489.85, total, 0.01);
        }

        [TestMethod]
        public void CanComputeCurcuit()
        {
            var circuit = new Circuit();
            circuit.Battery = 5.0;

            circuit.Resistor1.Resistance = 3000.0;
            circuit.Resistor2.Resistance = 5000.0;
            circuit.Resistor3.Resistance = 10000.0;

            circuit.Compute();

            Assert.AreEqual(2.4, circuit.Voltage1, 0.1);
        }
    }
}
