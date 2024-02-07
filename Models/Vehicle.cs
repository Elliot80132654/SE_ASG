using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem.Models
{
    public class Vehicle
    {
        public required string licensePlate { get; set; }
        public string type { get; set; }
        public SeasonPass assignedSeasonPass { get; set; }

    }
}
