using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem.Models
{
    public class SeasonPass
    {
        public required string passId {  get; set; }
        public string status { get; set; }
        public string holderName { get; set; }
        public Vehicle assignedVechicle { get; set; }
        public string additionalStatus { get; set; }

    }
}
