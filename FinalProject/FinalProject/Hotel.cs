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
                if ((numPeople / value) <= 4)
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

    }
}
