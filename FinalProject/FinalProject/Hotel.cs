using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Hotel : Reservation
    {
        private string city;






        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

    }
}
