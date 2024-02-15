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
                pass.TransferPassToNewVehicle(new Vehicle(newVehicleRegNumber, "Car", null)); // Assuming null for additional details
                Console.WriteLine("Season pass transferred to the new vehicle successfully.");
                TransferObservable.NotifyObservers(pass, newVehicleRegNumber); // Notify observers
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