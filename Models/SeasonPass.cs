using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem.Models
{
    public abstract class SeasonPass
    {
        public abstract string PassId {  get; set; }
        public string Status { get; set; }
        public string HolderName { get; set; }
        public Vehicle AssignedVechicle { get; set; }
        public string AdditionalStatus { get; set; }

        public SeasonPass(string passId, string status, string holderName, Vehicle assignedVechicle, string additionalStatus)
        {
            PassId = passId;
            Status = status;
            HolderName = holderName;
            AssignedVechicle = assignedVechicle;
            AdditionalStatus = additionalStatus;
        }
    }
}
