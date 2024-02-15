using ParkingManagementSystem.Models;
using ParkingManagementSystem.Services;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace ParkingManagementSystem
{
    class Program
    {
        static void Main()
        {
            Vehicle vehicle = new Vehicle("ABC123", "Car", null);
            SeasonPass monthlyPass = new MonthlyPass("123", "Active", "John Doe", vehicle, "AdditionalStatus", 1, 2);


            DisplayMenu();
            string user = Console.ReadLine();
            if(int.Parse(user) == 1 ) 
            {
                // implement Apply season Pass here
            }
            else if(int.Parse(user) == 2)
            {
                TransferSeasonPass();
                        break;
            }
            else if(int.Parse(user) == 3)
            {
                Console.WriteLine("Please enter your season pass ID to renew:");
                string passId = Console.ReadLine();
                // Use the static method to get the season pass
                SeasonPass pass = SeasonPassRepository.GetSeasonPassById(passId);

                // Check if the returned pass is indeed a MonthlyPass
                if (pass is MonthlyPass validPass)
                {
                    RenewSeasonPass renewService = new RenewSeasonPass();
                    renewService.Renew(validPass); // Use the new variable name 'validPass'
                }
                else
                {
                    Console.WriteLine("Invalid season pass ID. Please try again.");
                }
            }
            else if (int.Parse(user) == 4)
            {
                monthlyPass.TerminateSeasonPass("reason");
                // Terminate Season Pass
            }
            else if (int.Parse(user) == 5) 
            {
                List<Application> applications = new List<Application>();
                // create dummy data

                Admin ad = new Admin(applications);
                ad.ProcessPass();
            }
            // Example usage of Carpark
            Carpark campusCarpark = new Carpark(1, "Campus Carpark", "Main Campus", 1, 0);

            //campusCarpark.ParkCar();
            //campusCarpark.ParkMotorbike();

            //campusCarpark.VacateCarSpot();
            //campusCarpark.VacateMotorbikeSpot();
        }
        public static void DisplayMenu()
        {
            Console.WriteLine("Welcome to the NP Parking system\n" +
                "\n1. Apply Season Pass" +
                "\n2. Transfer Season Pass" +
                "\n3. Renew Season Pass" +
                "\n4. Terminate Season Pass" +
                "\n5. Process Season Pass Application"+
                "\n" +
                "\nYour option: ");
        }

        using System;
using System.Collections.Generic;

namespace ParkingManagementSystem.Services
{
    //Define the IObserver interface
    public interface IObserver
    {
        void Update(SeasonPass pass, string newVehicleRegNumber);
    }

    //Define the IObservable interface
    public interface IObservable
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void NotifyObservers(SeasonPass pass, string newVehicleRegNumber);
    }

    //Implement concrete observer classes
    public class TransferObserver : IObserver
    {
        public void Update(SeasonPass pass, string newVehicleRegNumber)
        {
            // Handle the transfer event
            Console.WriteLine($"TransferObserver: Season pass with ID {pass.PassId} transferred to new vehicle with registration number {newVehicleRegNumber}");
        }
    }

    //Implement a concrete observable class
    public class TransferObservable : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(SeasonPass pass, string newVehicleRegNumber)
        {
            foreach (var observer in observers)
            {
                observer.Update(pass, newVehicleRegNumber);
            }
        }
    }

    //modify TransferSeasonPass class to use observer pattern
    public class TransferSeasonPass
    {
        private static TransferObservable transferObservable = new TransferObservable();

        public static void TransferPass(SeasonPass pass, string newVehicleRegNumber)
        {
            if (pass != null && pass.Vehicle.Type == "Car")
            {
                // Transfer pass to new vehicle
                pass.TransferPassToNewVehicle(new Vehicle(newVehicleRegNumber, "Car", null)); // Assuming null for additional details

                // Notify observers
                transferObservable.NotifyObservers(pass, newVehicleRegNumber);
            }
            else if (pass == null)
            {
                Console.WriteLine("Invalid season pass. Transfer failed.");
            }
            else
            {
                Console.WriteLine("This pass is not for a car. Transfer is not allowed.");
            }
        }

        public static void SubscribeObserver(IObserver observer)
        {
            transferObservable.Subscribe(observer);
        }

        public static void UnsubscribeObserver(IObserver observer)
        {
            transferObservable.Unsubscribe(observer);
        }
    }
}

    }
}
