using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem.Models
{
    public class MonthlyPass : SeasonPass
    {
        public override string PassId { get; set; } // Override PassId from SeasonPass

        // Constructor
        public MonthlyPass(string passId, string status, string holderName, Vehicle assignedVechicle, string additionalStatus, int startMonth, int endMonth)
            : base(passId, status, holderName, assignedVechicle, additionalStatus, startMonth, endMonth)
        {
            
        }
    }
}
