using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem.Models
{
    public class Vehicle
    {
        public string LicensePlate { get; set; }
        public string Type { get; set; }?
        public SeasonPass AssignedSeasonPass { get; set; }

        public Vehicle(string licensePlate, string type, SeasonPass assignedSeasonPass)
        {
            LicensePlate = licensePlate;
            Type = type;
            AssignedSeasonPass = assignedSeasonPass;
        }
    }
}
