using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Flight : Reservation
    {
        string depart;
        string arrive;
       

        int CalculateDistance(int a, int b )
        {

            return a;
        }

        public string Depart { get; set; }
        public string Arrive { get; set; }

        public Flight()
        {
            depart = null;
            arrive = null;

        }

        ~Flight()
        {

        }
    }
}
