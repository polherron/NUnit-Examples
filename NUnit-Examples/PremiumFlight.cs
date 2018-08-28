using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Examples
{
    public class PremiumFlight : Flight
    {
        public PremiumFlight(int id) : base(id)
        {
        }

        public override bool AddPassenger(Passenger passenger)
        {
            if (passenger.IsVip)
            {
                return passengersList.Add(passenger);
            }
            return false;
        }

        public override bool RemovePassenger(Passenger passenger)
        {
            if (passenger.IsVip)
            {
                return passengersList.Remove(passenger);
            }
            return false;
        }
    }
}
