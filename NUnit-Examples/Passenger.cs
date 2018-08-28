using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Examples
{
    public class Passenger
    {
        private String name;
        private Boolean vip;

        public Passenger(string name, bool vip)
        {
            this.Name = name;
            this.vip = vip;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public bool IsVip
        {
            get
            {
                return vip;
            }

            set
            {
                vip = value;
            }
        }

    }
}
