using System;

public class ParkingLot
{
    public int Capacity { get; set; }
    public int OccupiedSpots { get; set; }

    public ParkingLot(int capacity)
    {
        Capacity = capacity;
        OccupiedSpots = 0;
    }

    public bool ParkVehicle()
    {
        if (OccupiedSpots < Capacity)
        {
            OccupiedSpots++;
            return true;
        }
        else
        {
            Console.WriteLine("Parking lot is full!");
            return false;
        }
    }

    public void VacateSpot()
    {
        if (OccupiedSpots > 0)
        {
            OccupiedSpots--;
            Console.WriteLine("Parking spot vacated.");
        }
        else
        {
            Console.WriteLine("No vehicles to vacate.");
        }
    }
}
