using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingManagementSystem.Models;


namespace ParkingManagementSystem.Services
{
    public class RenewSeasonPass
    {
        public void Renew(MonthlyPass pass)
        {
            // Check if the pass is eligible for renewal (not expired and not terminated)
            if (pass.Status == "Active" && pass.EndMonth >= DateTime.Now.Month)
            {
                // Process the payment
                const decimal renewalFee = 50.00m; // Flat renewal fee
                Console.WriteLine($"The renewal fee is: {renewalFee:C}.");
                Console.WriteLine("Would you like to proceed with the payment? (yes/no)");

                string userResponse = Console.ReadLine();
                if (userResponse.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    //  Make payment successful for testing
                    bool paymentSuccess = true; 

                    if (paymentSuccess)
                    {
                        // Renewal adds one month to the end month
                        pass.EndMonth = (pass.EndMonth % 12) + 1;
                        Console.WriteLine($"Season pass renewed successfully. New expiry month: {pass.EndMonth}.");
                    }
                    else
                    {
                        Console.WriteLine("Payment failed. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Renewal cancelled by the user.");
                }
            }
            else
            {
                Console.WriteLine("Season pass is not eligible for renewal (may be expired or terminated).");
            }
        }
    }
}

