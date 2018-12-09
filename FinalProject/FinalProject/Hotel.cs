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
        private int numRooms = 0;
        private int numNights = 0;
        private int numStars = 0;
        private double price = 0;
        private Random r = new Random();



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

        public int NumRooms
        {
            get
            {
                return numRooms;
            }
            set
            {
                double k;
                k = numPeople;

                if ((k / value)  <= 4.00)
                {
                    numRooms = value;
                }
                else
                {
                    int i;
                    int minRooms;
                    minRooms = (numPeople +3) / 4;
                    Console.WriteLine("The max amount of people per room is 4; You must book " + minRooms + " rooms. " +
                        "Would you like to book " + minRooms + " rooms? 1) Yes or 2) for No\n");

                    i = Int32.Parse(Console.ReadLine());

                    if (i == 1)
                    {
                        numRooms = minRooms;
                    }
                    else
                    {
                        numRooms = 0;
                    }
                }
            }
        }

        public int NumNights
        {
            get
            {
                return numNights;
            }
            set
            {
                numNights = value;
            }
        }

        public int NumStars
        {
            get
            {
                return numStars;
            }
            set
            {
                if( value >= 2 && value <= 5)
                {
                    numStars = value;
                }
                else if ( value < 2)
                {
                    numStars = 2;
                }
                else if ( value >5 )
                {
                    numStars = 5;
                }
            }
        }

        public double Price
        {
            get
            {
                if (numStars == 2)
                {
                    price = r.Next(45, 100);
                }
                else if (numStars == 3)
                {
                    price = r.Next(100, 180);
                }
                else if (numStars == 4)
                {
                    price = r.Next(150, 250);
                }
                else if (numStars == 5)
                {
                    price = r.Next(250, 600);
                }
                return price;
            }
            set
            {

            }
        }

        public Hotel()
        {
            city = null;
            numRooms = 0;
            numNights = 0;
            numStars = 0;
            price = 0;
        }

    }
}
