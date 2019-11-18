using System;
using System.Collections.Generic;

namespace Csharp-CarLot
{
    class Program
{
    static void Main(string[] args)
    {
        List<Cars> carLot = new List<Cars>;

        Car ford = new Car("Ford", "Bronco", 80_000);
        ford.Year = 1986;
        ford.Color = "Pearl";
        ford.IsInspectected = true;
        ford.CountryOfOrigin = "USA";

        Car toyota = new Car("Toyota", "4Runner", 300)
        {
            Year = 2019,
            Color = "White",
            IsInspectected = false,
            CountryOfOrigin = "Japan"
        };

        Car chevrolet = new Car("Chevrolet", "Camara", 1000)
        {
            Year = 2019,
            Color = "Red",
            IsInspectected = true,
            CountryOfOrigin = "USA"
        };

        carLot.Add(ford);
        carLot.Add(toyota);
        carLot.Add(chevrolet);

        Console.WriteLine($"The Ford has {ford.Mileage} miles");
        ford.Drive(10);
        Console.WriteLine($"The Ford has not driven {ford.Mileage}");
        Console.WriteLine(ford.Description);
        Console.WriteLine(chevrolet.Description);
        Console.WriteLine(toyota.Description);
    }
}
}
