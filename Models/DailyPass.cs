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
        public float DailyChargeRate { get; set; }

        // Constructor
        public DailyPass(string passId, string status, string holderName, Vehicle assignedVechicle, string additionalStatus, int startMonth, int endMonth, float dailyChargeRate)
            : base(passId, status, holderName, assignedVechicle, additionalStatus, startMonth, endMonth)
        {
            DailyChargeRate = dailyChargeRate;
        }
    }
}
