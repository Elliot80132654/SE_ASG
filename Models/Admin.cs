using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem.Models
{
    public class Admin
    {
        public List<Application> AppList {  get; set; }

        public Admin(List<Application> appList)
        {
            AppList = appList;
        }
        public void DisplayApp(Application app)
        {
            Console.WriteLine(app.AppId.ToString(), app.Name, app.UserId, app.Password, app.MonthStart, app.MonthEnd, app.PaymentMethod, app.Vehicle);
        }

        public bool ProcessPass()
        {
            bool approval = false;
            bool validInput = false;
            foreach(Application app in AppList)
            {
                DisplayApp(app);
            }
            Console.WriteLine("Choose application to review: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                Application selApp = AppList[int.Parse(input)];
                // Display the result
                DisplayApp(selApp);
                Console.WriteLine("Do you wish to approve this application? [Y/N] ");
                string cfm = Console.ReadLine();
                while (validInput == false)
                {
                    if (cfm.ToLower() == "y")
                    {
                        approval = true;
                    }
                    else if (cfm.ToLower() == "n")
                    {
                        approval = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input, please Try again");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid ID.");
            }

            return approval;
        }

    }
}
