using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit_Examples;

namespace NUnitExamplesTest
{

    [TestClass]
    public class OrdinaryPassenger
    {
        private Flight economyFlight;
        private Passenger mike;
        private Passenger john;


        [TestInitialize]
        public void setUp()
        {
            economyFlight = new EconomyFlight(1);
            mike = new Passenger("Mike", false);
            john = new Passenger("John", true);
        }

        [TestMethod]
        [TestCategory("Then you can add and remove him from an economy flight")]
        public void TestEconomyFlightOrdinaryPassenger()
        {
            Assert.AreEqual(1, economyFlight.Id);
            Assert.IsTrue(economyFlight.AddPassenger(mike));
            Assert.AreEqual(2, economyFlight.getPassengersSet().Count);
            Assert.IsTrue(economyFlight.getPassengersSet().Contains(mike));
            Assert.IsTrue(economyFlight.RemovePassenger(mike));
            Assert.AreEqual(0, economyFlight.getPassengersSet().Count);
        }

    }
}
