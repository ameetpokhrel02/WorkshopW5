
    // Abstract Class 
    public abstract class AbstractVehicle
    {
        // Abstract methods must be implemented by derived classes 
        public abstract void StartEngine();
        public abstract void StopEngine();

        // Concrete method
        public void Display()
        {
            Console.WriteLine("This is a vehicle.");
        }
    }

    // Derived Class 1
    public class Car : AbstractVehicle
    {
        // Implement abstract methods
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started with ignition key.");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Car engine shut down.");
        }
    }

    // Derived Class 2:
    public class Bike : AbstractVehicle
    {
        // Implement abstract methods
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started with a kick-start.");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Bike engine stopped by cutting fuel.");
        }
    }