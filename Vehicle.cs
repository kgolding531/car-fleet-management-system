using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Two_OOP
{
    class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        public int SeatingCapacity { get; set; }
        public string FuelType { get; set; }
        public DateTime InsuranceExpiryDate { get; set; } = new DateTime();
        public DateTime FitnessExpiryDate { get; set; } = new DateTime();

        public void setDetails()
        {
            Console.Write("\nEnter Make: ");
            string make = Console.ReadLine();

            Console.Write("Enter Model: ");
            string model = Console.ReadLine();

            // INPUT VALIDATION
            int year;
            do
            {
                Console.Write("Enter the Year: ");
                string yearInput = Console.ReadLine();
                if (!int.TryParse(yearInput, out year) || year < 1900 || year > DateTime.Now.Year)
                {
                    Console.WriteLine("Invalid input. Please enter a valid year!");
                }
            } while (year < 1900 || year > DateTime.Now.Year);

            Console.Write("Enter Color: ");
            string color = Console.ReadLine();

            int seatingCapacity;
            do
            {
                Console.Write("Enter Seating Capacity: ");
                string seatingCapacityInput = Console.ReadLine();
                if (!int.TryParse(seatingCapacityInput, out seatingCapacity) || seatingCapacity <= 0)
                {
                    Console.WriteLine("Invalid seating capacity. Please enter a valid number!");
                }
            } while (seatingCapacity <= 0);

            Console.Write("Enter Fuel Type: ");
            string fuelType = Console.ReadLine();

            DateTime insuranceExpiryDate;
            do
            {
                Console.Write("Enter Insurance Expiry Date (MM/DD/YYYY): ");
                string insuranceExpiryInput = Console.ReadLine();
                if (!DateTime.TryParseExact(insuranceExpiryInput, "MM/DD/YYYY", null, System.Globalization.DateTimeStyles.None, out insuranceExpiryDate))
                {
                    Console.WriteLine("Invalid date format. Please enter the date in MM/DD/YYYY format!");
                }
            } while (insuranceExpiryDate == DateTime.MinValue);

            DateTime fitnessExpiryDate;
            do
            {
                Console.Write("Enter Fitness Expiry Date (MM/DD/YYYY): ");
                string fitnessExpiryInput = Console.ReadLine();
                if (!DateTime.TryParseExact(fitnessExpiryInput, "MM/DD/YYYY", null, System.Globalization.DateTimeStyles.None, out fitnessExpiryDate))
                {
                    Console.WriteLine("Invalid date format. Please enter the date in MM/DD/YYYY format!");
                }
            } while (fitnessExpiryDate == DateTime.MinValue);
        }

        // NEEDS FIXING TO HAVE VISUALLY APPALING OUTPUT TO THE USER
        // VEHICLE ONE: TYPE CAR... ETC... LIST FORMAT.

        // AND THE OUTPUT IS INCORRECT...
        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, Color: {Colour}, Seating Capacity: {SeatingCapacity}, Fuel Type: {FuelType}, Insurance Expiry: {InsuranceExpiryDate.ToShortDateString()}, Fitness Expiry: {FitnessExpiryDate.ToShortDateString()}";
        }
    }
}