using _02VehicleManagementSystem;

namespace _02VehicleManagementSystem;

public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set;}
    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public virtual void DisplayInfo()
    {
        System.Console.WriteLine($"Marka: {Make}, Model: {Model}, Yıl: {Year}");
    }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    public Car(string make, string model, int year, int numberOfDoors)
    :base(make, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Kapı sayısı: {NumberOfDoors}");
    }
}

public class Bicycle : Vehicle
{
    public bool HasGear { get; set; }
    public Bicycle(string make, string model, int year, bool hasGear)
        :base(make, model, year)
        {
            HasGear = hasGear;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            System.Console.WriteLine($"Vitesli mi: {(HasGear ? "Evet" : "Hayır")}");
        }
}
public class Motorcycle : Vehicle
{ 
    public bool HasSidecar { get; set; }
        public Motorcycle(string make, string model, int year, bool hasSidecar)
        : base(make, model, year)
        {  
    
        HasSidecar = hasSidecar;
        }
        public override void DisplayInfo()
        {
        base.DisplayInfo();
        System.Console.WriteLine($"Yan Sepet Var mı: {(HasSidecar ? "Evet" : "Hayır")}");
        }
}

class Program
{
    static void Main(string[]args)
    {
    Car car = new Car ("Toyota", "Corolla", 2020, 4);
    Bicycle bicycle = new Bicycle("Giant", "Escape 3", 2019, true);
    Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Street 750", 2021, false); 

    car.DisplayInfo();
    System.Console.WriteLine();

    bicycle.DisplayInfo();
    System.Console.WriteLine();

    motorcycle.DisplayInfo();
    }
    
}