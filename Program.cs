using Assignment_Two_OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

/*
 * Author: Kevaughn Golding
 * Student ID: 20216234
*/

namespace AssignmentTwo
{
    internal class OOP
    {
        static string exit;
        public static void Main(string[] args)
        {           
            var vehicles = new List<Vehicle>();

            Console.WriteLine("Welcome to the Vehicle Fleet Management system!");

            Console.ReadKey();

            do
            {
                Menu:
                Console.WriteLine("\n*****MENU*****");
                Console.WriteLine("1. Add Vehicle");
                Console.WriteLine("2. See Vehicles");
                Console.WriteLine("3. Exit");
               
                Action:
                Console.Write("\nEnter the action you would like to perform: ");
                string userInput = Console.ReadLine();
                byte option;

                if (!byte.TryParse(userInput, out option))
                {
                    Console.WriteLine("Input must be a number!");
                    goto Action;
                }
                else
                {
                    if (option > 3 || option < 1)
                    {
                        Console.WriteLine("Input must be greater than 1 or less than 3!");
                        goto Action;
                    }
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine("\n1. Car");
                        Console.WriteLine("2. Van");
                        Console.WriteLine("3. SUV");

                        VehicleType:
                        Console.Write("\nChoose vehicle type you want to add to the inventory: ");
                        string userInput2 = Console.ReadLine();
                        byte option2;

                        if (!byte.TryParse(userInput2, out option2))
                        {
                            Console.WriteLine("Input must be a number!");
                            goto VehicleType;
                        }
                        else
                        {
                            if (option > 3 || option < 1)
                            {
                                Console.WriteLine("Input must be greater than 1 or less than 3!");
                                goto VehicleType;
                            }
                        }

                        switch (option2)
                        {
                            case 1:
                                Car car = new Car();
                                car.setDetails();
                                vehicles.Add(car);
                                Console.WriteLine(car.FitnessExpiryDate.ToShortDateString()); // outputs time too ... not needed
                                break;

                            case 2:
                                Van van = new Van();
                                van.setDetails();
                                vehicles.Add(van);
                                break;

                            case 3:
                                SUV suv = new SUV();
                                vehicles.Add(suv);
                                suv.setDetails();
                                break;

                            default:
                                Console.WriteLine("\nWrong option entered!");
                                break;
                        }
                        // USER VALIDATION NEEDED
                        Console.Write("\nWould you like to enter more vehicles to the inventory? (yes/no): ");
                        exit = Console.ReadLine();

                        if (exit.ToLower() == "no")
                        {
                            goto Menu;
                        }
                        break;

                    case 2:
                        if (vehicles.Count == 0)
                        {
                            // USER VALIDATION NEEDED
                            Console.WriteLine("\nThere are no vehicles listed in the inventory.");
                            Console.WriteLine("Would you like to add some? (yes/no).");
                            string toAdd = Console.ReadLine();

                            if (toAdd.ToLower() == "yes")
                            {
                                goto Menu;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nHere is the list of vehicles currently present in the inventory: ");

                            foreach (Vehicle vehicle in vehicles)
                            {
                                Console.WriteLine(vehicle.ToString());
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nThank you for using our services! Goodbye.");
                        break;

                    default:
                        Console.WriteLine("\nWrong option entered!");
                        break;
                }
            }
            while (exit.ToLower() == "yes");

            Console.WriteLine("\nThe total number of vehicles you have in the inventory are: {0}", vehicles.Count);
        }
    }
}