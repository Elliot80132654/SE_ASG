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
                // Terminate Season Pass
            }
            else if (int.Parse(user) == 5) 
            {
                Vehicle honda = new("SGX1999D", "car", assignedSeasonPass: null);
                List<Application> applications = new List<Application>();
                Application app1 = new Application(1,"Luke","s10222035d","this_is_dummy_text",1,6,"debit",honda,"daily");
                Application app2 = new Application(1, "Joey", "s10220035d", "this_is_dummy_text", 1, 6, "mastercard", honda, "daily");
                Application app3 = new Application(1, "Jin Kai", "s10120352d", "this_is_dummy_text", 1, 6, "visa", honda, "monthly");
                Application app4 = new Application(1, "Gareth", "s10223235d", "this_is_dummy_text", 1, 6, "cashcard", honda, "daily");
                Application app5 = new Application(1, "Elliot", "s10222235d", "this_is_dummy_text", 1, 6, "debit", honda, "daily");
                applications.Add(app1);
                applications.Add(app2);
                applications.Add(app3);
                applications.Add(app4);
                applications.Add(app5);
                // create dummy data

                Admin ad = new Admin(applications);
                ad.ProcessPass(applications);
            }
            // Example usage of Carpark
            Carpark campusCarpark = new Carpark(1, "Campus Carpark", "Main Campus", 1, 0);

            campusCarpark.ParkCar();
            campusCarpark.ParkMotorbike();

            campusCarpark.VacateCarSpot();
            campusCarpark.VacateMotorbikeSpot();
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
