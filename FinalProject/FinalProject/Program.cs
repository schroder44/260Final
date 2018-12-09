using System;
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

            double fprice = 0;
            double hprice = 0;
            double tax = .06;
            double total = 0;
            
            int fMultiply = 1;
            int hMultiply = 1;

            while (i != 0)
            {
                Console.WriteLine("Welcom to Zach's Flight/Hotel Booking System \n" +
                   "What would you like to do: \n" +
                   "\n" +
                   "1: Book a Flight \n" +
                   "2: Book a Hotel \n" +
                   "0: Exit Program\n" +
                   "\n" +
                   "Please enter in the number of your selection: ");

                i = Int32.Parse(Console.ReadLine());

                int z = 0;

                while (z < 2)
                {

                    if (i == 1)//chose Flight
                    {
                        ++z;

                        Flight flight = new Flight();
                        Console.WriteLine("You have selected booking a flight \n" +
                            "Where are you Flying from? \n(Please enter the number of your selection)\n\n" +
                            "0: Los Angeles (LAX)    1: New York City (JFK)\n" +
                            "2: Denver (DEN)         3: Chicago (ORD)\n" +
                            "4: Seattle (SEA)        5: Dallas / Fort Worth (DFW)\n" +
                            "6: Atlanta (ATL)        7: Las Vegas (LAS)\n" +
                            "8: Phoenix (PHX)        9: Sioux Falls (FSD)");

                        j = Int32.Parse(Console.ReadLine());
                        
                        switch(j)
                        {
                            case 0:
                                flight.Depart = "Los Angeles";
                                break;
                            case 1:
                                flight.Depart = "New York City";
                                break;
                            case 2:
                                flight.Depart = "Denver";
                                break;
                            case 3:
                                flight.Depart = "Chicago";
                                break;
                            case 4:
                                flight.Depart = "Seattle";
                                break;
                            case 5:
                                flight.Depart = "Dallas / Fort Worth";
                                break;
                            case 6:
                                flight.Depart = "Atlanta";
                                break;
                            case 7:
                                flight.Depart = "Las Vegas";
                                break;
                            case 8:
                                flight.Depart = "Phoenix";
                                break;
                            case 9:
                                flight.Depart = "Sioux Falls";
                                break;
                        }

                        Console.WriteLine("Where are you Flying to? \n(Please enter the number of your selection)\n\n" +
                           "0: Los Angeles (LAX)    1: New York City (JFK)\n" +
                           "2: Denver (DEN)         3: Chicago (ORD)\n" +
                           "4: Seattle (SEA)        5: Dallas / Fort Worth (DFW)\n" +
                           "6: Atlanta (ATL)        7: Las Vegas (LAS)\n" +
                           "8: Phoenix (PHX)        9: Sioux Falls (FSD)\n");

                        k = Int32.Parse(Console.ReadLine());

                        switch (k)
                        {
                            case 0:
                                flight.Arrive = "Los Angeles";
                                break;
                            case 1:
                                flight.Arrive = "New York City";
                                break;
                            case 2:
                                flight.Arrive = "Denver";
                                break;
                            case 3:
                                flight.Arrive = "Chicago";
                                break;
                            case 4:
                                flight.Arrive = "Seattle";
                                break;
                            case 5:
                                flight.Arrive = "Dallas / Fort Worth";
                                break;
                            case 6:
                                flight.Arrive = "Atlanta";
                                break;
                            case 7:
                                flight.Arrive = "Las Vegas";
                                break;
                            case 8:
                                flight.Arrive = "Phoenix";
                                break;
                            case 9:
                                flight.Arrive = "Sioux Falls";
                                break;
                        }

                        fprice = flight.price[j, k];

                        Console.WriteLine("How many seats do you need booked?\n");

                        flight.numPeople = Int32.Parse(Console.ReadLine());
                        fMultiply = fMultiply * flight.numPeople;


                        Console.WriteLine("Would you like to upgrade to First Class? 1) Yes / 2) No\n");

                        j = Int32.Parse(Console.ReadLine()); 

                        if (j == 1)
                        {
                            fMultiply = fMultiply * 3;
                        }

                        fprice = fprice * fMultiply;

                        Console.WriteLine("\n"+"Your Flight from " + flight.Depart + " to " + flight.Arrive +
                           " for " + flight.numPeople + " people will cost: $" + fprice + "\n");
                        
                        if (z < 2)
                        { 
                            Console.WriteLine("Would you also like to make a Hotel booking? 1) Yes / 2) No\n");

                            j = Int32.Parse(Console.ReadLine());

                            if (j == 1)
                            {
                                i = 2;
                            }
                            else
                            {
                            z = 2;
                            }
                        }

                    }
                    else if (i == 2)//Chose Hotel
                    {
                        ++z;

                        Hotel hotel = new Hotel();

                        Console.WriteLine("You have selected booking a hotel \n" +
                           "What city will you be staying in? \n(Please enter the number of your selection)\n\n" +
                           "0: Los Angeles (LAX)    1: New York City (JFK)\n" +
                           "2: Denver (DEN)         3: Chicago (ORD)\n" +
                           "4: Seattle (SEA)        5: Dallas / Fort Worth (DFW)\n" +
                           "6: Atlanta (ATL)        7: Las Vegas (LAS)\n" +
                           "8: Phoenix (PHX)        9: Sioux Falls (FSD)\n");

                        k = Int32.Parse(Console.ReadLine());

                        switch (k)
                        {
                            case 0:
                                hotel.City = "Los Angeles";
                                break;
                            case 1:
                                hotel.City = "New York City";
                                break;
                            case 2:
                                hotel.City = "Denver";
                                break;
                            case 3:
                                hotel.City = "Chicago";
                                break;
                            case 4:
                                hotel.City = "Seattle";
                                break;
                            case 5:
                                hotel.City = "Dallas / Fort Worth";
                                break;
                            case 6:
                                hotel.City = "Atlanta";
                                break;
                            case 7:
                                hotel.City = "Las Vegas";
                                break;
                            case 8:
                                hotel.City = "Phoenix";
                                break;
                            case 9:
                                hotel.City = "Sioux Falls";
                                break;
                        }

                        Console.WriteLine("How many people will be staying?\n");

                        hotel.numPeople = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("How many rooms would you like to book?\n");

                        hotel.NumRooms = Int32.Parse(Console.ReadLine());
                        
                        if(hotel.NumRooms > 0)
                        {
                            hMultiply = hMultiply * hotel.NumRooms;

                            Console.WriteLine("How many nights will you be staying?");

                            hotel.NumNights = Int32.Parse(Console.ReadLine());

                            hMultiply = hMultiply * hotel.NumNights;

                            Console.WriteLine("What class hotel would you like to stay in? (Hotel Star Rating: between 2-5)");

                            hotel.NumStars = Int32.Parse(Console.ReadLine());

                            Console.WriteLine("Would you like to upgrade to a Suite?  1)Yes  2)No\n");

                            j = Int32.Parse(Console.ReadLine());

                            if(j == 1)
                            {
                                hMultiply = hMultiply * 2;
                            }

                            hprice = hotel.Price;
                            hprice *= hMultiply;

                            Console.WriteLine("The total cost for your " + hotel.NumStars + " star hotel booking in " + hotel.City + " for " + hotel.NumRooms +
                                " rooms for " + hotel.NumNights + " nights is: $" + hprice + ".\n");
                        }


                        if (z < 2)
                        {

                            Console.WriteLine("Would you also like to make a Flight booking? 1) yes / 2) no\n");

                            j = Int32.Parse(Console.ReadLine());

                            if (j == 1)
                            {
                                i = 1;
                            }
                            else
                            {
                                z = 2;
                            }
                        }
                        
                    }
                    else if (i == 0)//Exit Program
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Selection.\n");
                        i = 0;
                    }
                }

                i = 0;
            }

            total = hprice + fprice + 25;
            tax *= total;
            total = total + tax;

            Console.WriteLine("Your grand total for your booking(s) is:\n" +
                                "Flight booking total: $" + fprice +
                              "\nHotel booking total:  $" + hprice +
                              "\nBooking Fee:          $25.00" +
                              "\nTax (6%):             $" + tax +
                              "\nGrand total:          $" + total + "\n");

            Creditcard card = new Creditcard();

            Console.WriteLine("Please enter the first and last name, seperated by a space, on your credit card.\n");

            card.Name = Console.ReadLine();

            Console.WriteLine("Please enter in your credit card number.");

            card.Number = Console.ReadLine();

            Console.WriteLine("Thank you " + card.Name + " for using Zach's Booking system.\n" +
                "Your card ending in " + card.Number + " has been charged $" + total + " And your reservations made.\n" +
                "Have a great day");

            Console.ReadKey();

            
        }
    }
}
