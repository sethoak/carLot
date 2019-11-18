using System;

namespace Csharp-CarLot
{
    class Car
{
    //Fields are very similar to properties. The difference is by convention they are normally private and they don't have a 'get' or a 'set'.
    //use "_" for naming conventions on private instances.
    private string _vinNumber;
    //Constructor, we don't tell the return type. Just the nameclass. So, we need someone to enter these 3 basic things when entering a new car.
    //paramets of make model mileage
    public Car(string make, string model, int mileage)
    {
        Make = make;
        Model = model;
        Mileage = mileage;

        Random rand = new Random();
        _vinNumber = rand.Next(10000).ToString();
    }

    // get and set is like read/write. Devs can read and write to this property.
    public string Make { get; set; }
    public int Year { get; set; }
    public string Model { get; set; }
    public int Mileage { get; private set; }
    public string Color { get; set; }
    public string CountryOfOrigin { get; set; }
    public bool IsInspectected { get; set; }
    public void Drive(int milesDriven)
    {
        this.Mileage += milesDriven;
    }
    //computer properties
    public string Description
    {
        get
        {
            return $"{Year} {Make} {Model} with {Mileage} miles";
        }
    }

    public void Drive()
    {
        Mileage += 5;
    }
}
}