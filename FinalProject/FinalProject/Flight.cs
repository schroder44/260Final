using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Flight : Reservation
    {
        public double[,] price = new double[10, 10];
        string depart;
        string arrive;
        
        public string Depart { get; set; }


        public string Arrive { get; set; }

        public Flight()
        {
            for (int i = 0;i < 10; i++)
            {
                for (int k=0; k < 10; k++)
                {
                    if (k == i)
                    {
                        price[i, k] = 0;
                    }
                    else
                    {
                        price[i, k] = 200;
                    }
                }
            }
            depart = null;
            arrive = null;

        }

        ~Flight()
        {

        }
    }
}
