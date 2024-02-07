using System;
using System.Collections.Generic;

public class Carpark
{
    public int CarparkNumber { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public List<ParkingLot> CarParkingLots { get; set; }
    public List<ParkingLot> MotorbikeParkingLots { get; set; }

    public Carpark(int carparkNumber, string description, string location, int carCapacity, int motorbikeCapacity)
    {
        CarparkNumber = carparkNumber;
        Description = description;
        Location = location;
        CarParkingLots = new List<ParkingLot> { new ParkingLot(carCapacity) };
        MotorbikeParkingLots = new List<ParkingLot> { new ParkingLot(motorbikeCapacity) };
    }

    public void ParkCar()
    {
        if (CarParkingLots.Count > 0)
        {
            if (CarParkingLots[0].ParkVehicle())
            {
                Console.WriteLine("Car parked in the carpark.");
            }
        }
        else
        {
            Console.WriteLine("No car parking lots available in this carpark.");
        }
    }

    public void ParkMotorbike()
    {
        if (MotorbikeParkingLots.Count > 0)
        {
            if (MotorbikeParkingLots[0].ParkVehicle())
            {
                Console.WriteLine("Motorbike parked in the carpark.");
            }
        }
        else
        {
            Console.WriteLine("No motorbike parking lots available in this carpark.");
        }
    }

    public void VacateCarSpot()
    {
        if (CarParkingLots.Count > 0)
        {
            CarParkingLots[0].VacateSpot();
        }
    }

    public void VacateMotorbikeSpot()
    {
        if (MotorbikeParkingLots.Count > 0)
        {
            MotorbikeParkingLots[0].VacateSpot();
        }
    }
}
