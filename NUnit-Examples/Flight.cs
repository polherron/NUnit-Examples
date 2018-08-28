using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Examples
{
    public abstract class Flight
    {

        private int id;
        public HashSet<Passenger> passengersList = new HashSet<Passenger>();

        public Flight(int id)
        {
            this.id = id;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public ISet<Passenger> getPassengersSet()
        {
            return passengersList;
        }

        public abstract Boolean AddPassenger(Passenger passenger);

        public abstract Boolean RemovePassenger(Passenger passenger);
    }
}
