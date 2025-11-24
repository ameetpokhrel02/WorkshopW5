// 1. Abstract Class: ElectronicDevice
    public abstract class ElectronicDevice
    {
        // Private fields [cite: 73]
        private string brand;
        private double price;

        // Constructor to initialize Brand and Price
        public ElectronicDevice(string brand, double price)
        {
            this.brand = brand;
            this.price = price;
        }

        // Public properties (Encapsulation)
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double Price
        {
            get { return price; }
            set 
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Error: Price must be positive.");
                }
            }
        }

        // Abstract method to display device information 
        public abstract void ShowInfo();
    }

    // 2. Derived Class: Laptop 
    public class Laptop : ElectronicDevice
    {
        public Laptop(string brand, double price) : base(brand, price) { }

        // Extra method
        public void TurnOnBattery()
        {
            Console.WriteLine($" -> {Brand} Laptop battery is now charging.");
        }

        // Override ShowInfo()
        public override void ShowInfo()
        {
            Console.WriteLine($"\t[LAPTOP] Brand: {Brand}, Price: {Price:C}");
        }
    }

    // 2. Derived Class: Smartphone 
    public class Smartphone : ElectronicDevice
    {
        public Smartphone(string brand, double price) : base(brand, price) { }

        // Extra method
        public void EnableCamera()
        {
            Console.WriteLine($" -> {Brand} Smartphone camera enabled for picture taking.");
        }

        // Override ShowInfo() 
        public override void ShowInfo()
        {
            Console.WriteLine($"\t[SMARTPHONE] Brand: {Brand}, Price: {Price:C}");
        }
    }