using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingManagementSystem
{
    class Program
    {
        static void Main()
        {
            DisplayMenu();


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
                "\n5. Process Season Pass Application");
        }
    }
}
