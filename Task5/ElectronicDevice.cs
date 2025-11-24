// 1. Abstract Class: ElectronicDevice [cite: 71, 72]
    public abstract class ElectronicDevice
    {
        // Private fields [cite: 73]
        private string brand;
        private double price;

        // Constructor to initialize Brand and Price [cite: 76]
        public ElectronicDevice(string brand, double price)
        {
            this.brand = brand;
            this.price = price;
        }

        // Public properties (Encapsulation) [cite: 74]
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

        // Abstract method to display device information [cite: 75]
        public abstract void ShowInfo();
    }

    // 2. Derived Class: Laptop [cite: 84]
    public class Laptop : ElectronicDevice
    {
        public Laptop(string brand, double price) : base(brand, price) { }

        // Extra method [cite: 86]
        public void TurnOnBattery()
        {
            Console.WriteLine($" -> {Brand} Laptop battery is now charging.");
        }

        // Override ShowInfo() [cite: 87]
        public override void ShowInfo()
        {
            Console.WriteLine($"\t[LAPTOP] Brand: {Brand}, Price: {Price:C}");
        }
    }

    // 2. Derived Class: Smartphone [cite: 88]
    public class Smartphone : ElectronicDevice
    {
        public Smartphone(string brand, double price) : base(brand, price) { }

        // Extra method [cite: 90]
        public void EnableCamera()
        {
            Console.WriteLine($" -> {Brand} Smartphone camera enabled for picture taking.");
        }

        // Override ShowInfo() [cite: 91]
        public override void ShowInfo()
        {
            Console.WriteLine($"\t[SMARTPHONE] Brand: {Brand}, Price: {Price:C}");
        }
    }