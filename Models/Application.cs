using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem.Models
{
    public class Application
    {
        public int AppId { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public int MonthStart { get; set; }
        public int MonthEnd { get; set; }
        public string PaymentMethod { get; set; }
        public Vehicle Vehicle { get; set; }
        public string PassType { get; set; }

        public Application(int appId,string name, string userId, string password, int monthStart, int monthEnd, string paymentMethod, Vehicle vehicle, string passType) 
        {
            AppId = appId;
            Name = name;
            UserId = userId;
            Password = password;
            MonthStart = monthStart;
            MonthEnd = monthEnd;
            PaymentMethod = paymentMethod;
            Vehicle = vehicle;
            PassType = passType;
        }

        public bool ApprovePass(Application app)
        {
            bool approval = false;
            
            return approval;
        }
        
    }
}
