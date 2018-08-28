using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Examples
{
    public class EconomyFlight : Flight
    {
        public EconomyFlight(int id) : base(id)
        {
        }

        public override bool AddPassenger(Passenger passenger)
        {
            return passengersList.Add(passenger);
        }

        public override bool RemovePassenger(Passenger passenger)
        {
            if (!passenger.IsVip)
            {
                return passengersList.Remove(passenger);
            }
            return false;
        }
    }
}
