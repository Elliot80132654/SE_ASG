using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem.Models
{
    public class DailyPass : SeasonPass
    {
        public override string PassId { get; set; } // Override PassId from SeasonPass

        // Constructor
        public DailyPass(string passId, string status, string holderName, Vehicle assignedVehicle, string additionalStatus)
            : base(passId, status, holderName, assignedVehicle, additionalStatus)
        {

        }
    }
}
