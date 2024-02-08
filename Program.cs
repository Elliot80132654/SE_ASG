using ParkingManagementSystem.Models;
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
            SeasonPass monthlyPass = new MonthlyPass("123", "Active", "John Doe", vehicle, "AdditionalStatus", 1, 12);

            DisplayMenu();
            string user = Console.ReadLine();
            if(int.Parse(user) == 1 ) 
            {
                // implement Apply season Pass here
            }
            else if(int.Parse(user) == 2)
            {
                // implement Transfer season pass here
            }
            else if(int.Parse(user) == 3)
            {
                // implement Renew Season Pass
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
    }
}
