using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_RESERVATION
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            string choice;
            string roomnumber, name, number, address, selectagain;
            int occupants;

            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t Password: ");
            password = Console.ReadLine();

            while (password != "101")
            {
                Console.Clear();
                Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t\t Password: ");
                password = Console.ReadLine();
            }

            Console.Clear();
            Console.SetCursorPosition(60, 13);
            Console.Write("LOADING...");

            for (int i = 1; i <= 100; i++)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("█");
                }
                Console.SetCursorPosition(10, 15);
                System.Threading.Thread.Sleep(10);


            }




            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(@"
                                       __    __   ________   ________   ________    __           
                                      |  |  |  | |   __   | |__    __| |   _____|  |  |      
                                      |  |__|  | |  |  |  |    |  |    |  |__      |  |         
                                      |   __   | |  |  |  |    |  |    |   __|     |  |     ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(@"
                                      |  |  |  | |  |__|  |    |  |    |  |_____   |  |_____    
                                      |__|  |__| |________|    |__|    |________|  |________|  
");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
                                                       101  101010101   101
                                                     10101  101   101 10101
                                                       101  101   101   101
                                                       101  101   101   101
                                                       101  101   101   101
                                                       101  101010101   101
");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"
                                                     __________________________
                                                    |                          |
                                                    |        MAIN MENU         |
                                                    |__________________________|
                                                    |                          |
                                                    | A.ROOM RESERVATION       |
                                                    | B.VIEW OCCUPANT'S RECORD |
                                                    | C.VIEW RESERVED ROOMS    |
                                                    |__________________________|
 ");
            do
            {
            Console.Write("\t\t\t\t ENTER YOUR CHOICE [A/B/C]: ");
            choice = Console.ReadLine();
            
                while((choice == "a") || (choice == "A"))
                Console.Clear();
                Console.Write("\n\n\n\n\t\t\t\t\tSelect Room [1-5]: ");
                roomnumber = Console.ReadLine();

                if (roomnumber == "1")
                    Console.WriteLine(@" 
                         _________________________________________________________________________
                        |                                                                         |
                        |                            ROOM 1 AMINITIES                             |
                        |                                                                         |
                        |    2500 pesos per head/ a day         Cable Television Set              |
                        |    Limited of 5 persons               Refrigerator                      |
                        |    Luxury Bedding                     Complimentary Toiletries & Towels |
                        |    Free Wireless Internet             Good Showers                      |      
                        |    Centralized Aircon                                                   |
                        |_________________________________________________________________________|");

                if (roomnumber == "2")
                    Console.WriteLine(@" 
                         _________________________________________________________________________
                        |                                                                         |
                        |                            ROOM 2 AMINITIES                             |
                        |                                                                         |
                        |    2000 pesos per head/ a day         Cable Television Set              |
                        |    Limited of 5 persons               Complimentary Toiletries & Towels |
                        |    Luxury Bedding                     Good Showers                      |
                        |    Free Wireless Internet                                               |      
                        |    Centralized Aircon                                                   |
                        |_________________________________________________________________________|");
                if (roomnumber == "3")
                    Console.WriteLine(@" 
                         _________________________________________________________________________
                        |                                                                         |
                        |                            ROOM 3 AMINITIES                             |
                        |                                                                         |
                        |    2000 pesos per head/ a day         Cable Television Set              |
                        |    Limited of 5 persons               Complimentary Toiletries & Towels |
                        |    Luxury Bedding                     Good Showers                      |
                        |    Free Wireless Internet                                               |      
                        |    Centralized Aircon                                                   |
                        |_________________________________________________________________________|");
                if (roomnumber == "4")
                    Console.WriteLine(@" 
                         _________________________________________________________________________
                        |                                                                         |
                        |                            ROOM 4 AMINITIES                             |
                        |                                                                         |
                        |    1500 pesos per head/ a day         Complimentary Toiletries & Towels |
                        |    Limited of 2 persons               Good Showers                      |
                        |    Luxury Bedding                                                       |
                        |    Free Wireless Internet                                               |      
                        |    Centralized Aircon                                                   |
                        |_________________________________________________________________________|");
                if (roomnumber == "5")
                    Console.WriteLine(@" 
                         _________________________________________________________________________
                        |                                                                         |
                        |                            ROOM 4 AMINITIES                             |
                        |                                                                         |
                        |    1500 pesos per head/ a day         Complimentary Toiletries & Towels |
                        |    Limited of 2 persons               Good Showers                      |
                        |    Luxury Bedding                                                       |
                        |    Free Wireless Internet                                               |      
                        |    Centralized Aircon                                                   |
                        |_________________________________________________________________________|");

            }

            while ((choice == "a") || (choice != "A"));

            do
            {
                Console.Write("Changed your mind? Do you want to select again? [yes/no]: ");
                selectagain = Console.ReadLine();
                while ((choice != "yes") && (choice != "no") && (choice != "YES") && (choice != "NO")) ;
                {
                    Console.Clear();
                    Console.Write("Changed your mind? Do you want to select again? [yes/no]: ");
                    selectagain = Console.ReadLine();
                }
            }
            while (selectagain == "yes");


            do
            {

                Console.WriteLine("\n\n");
                Console.Write("\t\t\tEnter your Name: ");
                name = Console.ReadLine();
                Console.Write("\t\t\t        Address: ");
                address = Console.ReadLine();
                Console.Write("\t\t\t Contact Number: ");
                number = Console.ReadLine();

                Console.Write("\n\n\n\t\t\t Encode Again? [yes or no]: ");
                choice = Console.ReadLine();

                while ((choice != "yes") && (choice != "no") && (choice != "YES") && (choice != "NO"))
                {
                    Console.Write("\t\t\t\t Encode Again? [yes or no]: ");
                    choice = Console.ReadLine();
                }

            } while (choice == "yes");

        }
        }
    }

