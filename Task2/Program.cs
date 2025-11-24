Console.WriteLine("\n--- Task 2: Inheritance (Vehicle Hierarchy) ---");

var myCar = new Car("Honda", 180, 5);
var myMotorcycle = new Motorcycle("Yamaha", 220, false);

Console.WriteLine("\n--- Car Actions ---");
myCar.Start();
myCar.DisplayInfo();
myCar.Stop();

Console.WriteLine("\n--- Motorcycle Actions ---");
myMotorcycle.Start();
myMotorcycle.DisplayInfo();
myMotorcycle.Stop();