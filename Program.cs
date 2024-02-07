using System;

namespace ParkingManagementSystem
{
    class Program
    {
        static void Main()
        {
            // Example usage of Carpark
            Carpark campusCarpark = new Carpark(1, "Campus Carpark", "Main Campus", 1, 0);

            campusCarpark.ParkCar();
            campusCarpark.ParkMotorbike();

            campusCarpark.VacateCarSpot();
            campusCarpark.VacateMotorbikeSpot();
        }
    }
}
