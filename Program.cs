using ParkingManagementSystem.Models;
using ParkingManagementSystem.Services;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace ParkingManagementSystem
{
    class Program
    {
        static void Main()
        {
            Vehicle vehicle = new Vehicle("ABC123", "Car", null);
            SeasonPass monthlyPass = new MonthlyPass("123", "Active", "John Doe", vehicle, "AdditionalStatus", 1, 2);


            DisplayMenu();
            string user = Console.ReadLine();
            if(int.Parse(user) == 1 ) 
            {
                // implement Apply season Pass here
            }
            else if(int.Parse(user) == 2)
            {
                TransferSeasonPass();
                        break;
            }
            else if(int.Parse(user) == 3)
            {
                Console.WriteLine("Please enter your season pass ID to renew:");
                string passId = Console.ReadLine();
                // Use the static method to get the season pass
                SeasonPass pass = SeasonPassRepository.GetSeasonPassById(passId);

                // Check if the returned pass is indeed a MonthlyPass
                if (pass is MonthlyPass validPass)
                {
                    RenewSeasonPass renewService = new RenewSeasonPass();
                    renewService.Renew(validPass); // Use the new variable name 'validPass'
                }
                else
                {
                    Console.WriteLine("Invalid season pass ID. Please try again.");
                }
            }
            else if (int.Parse(user) == 4)
            {
                monthlyPass.TerminateSeasonPass("reason");
                // Terminate Season Pass
            }
            else if (int.Parse(user) == 5) 
            {
                List<Application> applications = new List<Application>();
                // create dummy data

                Admin ad = new Admin(applications);
                ad.ProcessPass();
            }
            // Example usage of Carpark
            Carpark campusCarpark = new Carpark(1, "Campus Carpark", "Main Campus", 1, 0);

            //campusCarpark.ParkCar();
            //campusCarpark.ParkMotorbike();

            //campusCarpark.VacateCarSpot();
            //campusCarpark.VacateMotorbikeSpot();
        }
        public static void DisplayMenu()
        {
            Console.WriteLine("Welcome to the NP Parking system\n" +
                "\n1. Apply Season Pass" +
                "\n2. Transfer Season Pass" +
                "\n3. Renew Season Pass" +
                "\n4. Terminate Season Pass" +
                "\n5. Process Season Pass Application"+
                "\n" +
                "\nYour option: ");
        }

        public static void TransferSeasonPass()
        {
            Console.WriteLine("Please enter your season pass ID:");
            string passId = Console.ReadLine();
            // Use the static method to get the season pass
            SeasonPass pass = SeasonPassRepository.GetSeasonPassById(passId);

            if (pass != null)
            {
                Console.WriteLine("Enter the new vehicle registration number:");
                string newVehicleRegNumber = Console.ReadLine();

                TransferSeasonPass.TransferPass(pass, newVehicleRegNumber);
            }
            else
            {
                Console.WriteLine("Invalid season pass ID. Please try again.");
            }
        
        }
    }
}
