namespace OOPAssignment
{
    // Base Class: Vehicle
    public class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public void Start()
        {
            Console.WriteLine($"{Brand} is starting.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} is stopping.");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"--- Vehicle Info ---");
            Console.WriteLine($"Brand: {Brand}, Max Speed: {Speed} km/h");
        }
    }

    // Derived Class 1: Car
    public class Car : Vehicle
    {
        public int Seats { get; set; }

        public Car(string brand, int speed, int seats) : base(brand, speed)
        {
            Seats = seats;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: Car, Number of Seats: {Seats}");
        }
    }

    // Derived Class 2: Motorcycle
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }

        public Motorcycle(string brand, int speed, bool hasSideCar) : base(brand, speed)
        {
            HasSideCar = hasSideCar;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: Motorcycle, Has Side Car: {(HasSideCar ? "Yes" : "No")}");
        }
    }
}