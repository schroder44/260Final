using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Reservation
    {
        double price = 0;
        int numAdults = 0;
        int numKids = 0;

        double CalcPrice(int Modifier)
        {
            double total;
            total = price * Modifier;
            return total;
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }


    }

}
