using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Examples
{
    public class BusinessFlight : Flight
    {
        public BusinessFlight(int id) : base(id)
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
            return false;
        }
    }
}
