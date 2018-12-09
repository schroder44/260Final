using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Flight : Reservation
    {
        internal double[,] price = new double[10, 10];
        private string depart;
        private string arrive;
        private Random r = new Random();
        
        public string Depart
        {
            get
            {
                return depart;
            }
            set
            {
                depart = value;
            }
        }
        public string Arrive
        {
            get
            {
                return arrive;
            }
            set
            {
                arrive = value;
            }
        }

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
                        price[i, k] = r.Next(150, 350);
                    }
                }
            }
            Depart = null;
            Arrive = null;

        }

        ~Flight()
        {

        }
    }
}
