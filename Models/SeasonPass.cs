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
        public Vehicle AVechicle { get; set; }
        public string AdditionalStatus { get; set; }
        public int StartMonth { get; set; }
        public int EndMonth { get; set; }


        public SeasonPass(string passId, string status, string holderName, Vehicle assignedVechicle, string additionalStatus, int startMonth, int endMonth)
        {
            PassId = passId;
            Status = status;
            HolderName = holderName;
            AVechicle = assignedVechicle;
            AdditionalStatus = additionalStatus;
            StartMonth = startMonth;
            EndMonth = endMonth;
        }
    }
}
