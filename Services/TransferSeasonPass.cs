using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem.Services
{
    public class TransferSeasonPass
    {
        public static void TransferPass(SeasonPass pass, string newVehicleRegNumber)
        {
            if (pass != null && pass.Vehicle.Type == "Car")
            {
                Vehicle newVehicle = new Vehicle(newVehicleRegNumber, "Car", null); 
                pass.TransferPassToNewVehicle(newVehicle);
                Console.WriteLine("Season pass transferred to the new vehicle successfully.");
            }
            else if (pass == null)
            {
                Console.WriteLine("Invalid season pass. Transfer failed.");
            }
            else
            {
                Console.WriteLine("This pass is not for a car. Transfer is not allowed.");
            }
        }
    }
}
