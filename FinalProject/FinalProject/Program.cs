﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -99;
            int j = -99;
            int k = -99;
            int fMultiply = 1;

            while (i != 0)
            {
                Console.WriteLine("Welcom to Zach's Flight/Hotel Reservation System \n" +
                   "What would you like to do: \n" +
                   "\n" +
                   "1: Book a Flight \n" +
                   "2: Book a Hotel \n" +
                   "0: Exit Program\n" +
                   "\n" +
                   "Please enter in the number of your selection: ");

                i = Int32.Parse(Console.ReadLine());

                if (i == 1)
                {
                    Flight flight = new Flight();
                    Console.WriteLine("You have selected booking a flight \n" +
                        "Where are you Flying from? \n(Please enter the number of your selection)\n\n" +
                        "0) Los Angeles (LAX)    1) New York City (JFK)\n" +
                        "2) Denver (DEN)         3) Chicago (ORD)\n" +
                        "4) Seattle (SEA)        5) Dallas / Fort Wroth (DFW)\n" +
                        "6) Atlanta (ATL)        7) Las Vegas (LAS)\n" +
                        "8) Phoenix (PHX)        9) Sioux Falls (FSD)");
                        
                    j = Int32.Parse(Console.ReadLine());
                    

                    Console.WriteLine("Where are you Flying to? \n(Please enter the number of your selection)\n\n" +
                        "0) Los Angeles (LAX)    1) New York City (JFK)\n" +
                        "2) Denver (DEN)         3) Chicago (ORD)\n" +
                        "4) Seattle (SEA)        5) Dallas / Fort Wroth (DFW)\n" +
                        "6) Atlanta (ATL)        7) Las Vegas (LAS)\n" +
                        "8) Phoenix (PHX)        9) Sioux Falls (FSD)\n");


                    


                }
                else if (i == 2)
                {

                }
                else if (i == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Selection, try again \n");
                }
            }
        }
    }
}
