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
        public List<SeasonPass> PassList { get; set; }

        public Admin(List<Application> appList)
        {
            AppList = appList;
        }
        public void DisplayApp(Application app)
        {
            Console.WriteLine(app.AppId.ToString(), app.Name, app.UserId, app.Password, app.PassType, app.MonthStart, app.MonthEnd, app.PaymentMethod, app.Vehicle);
        }

        public bool ProcessSeasonPass()
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
                Application selApp = AppList[int.Parse(input)]; //No safeguards to out of range
                // Display the result
                DisplayApp(selApp);
                
                while (validInput == false)
                {
                    Console.WriteLine("Do you wish to approve this application? [Y/N] ");
                    string cfm = Console.ReadLine();
                    if (cfm.ToLower() == "y")
                    {
                        approval = true;
                        validInput = true;
                    }
                    else if (cfm.ToLower() == "n")
                    {
                        approval = false;
                        validInput = true;
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
