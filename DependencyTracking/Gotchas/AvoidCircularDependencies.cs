using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gotchas.Examples;

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
    }
}
