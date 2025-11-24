Console.WriteLine("\n--- Task 4: Abstraction (Abstract Vehicle Hierarchy) ---");

AbstractVehicle abstractCar = new Car("BMW", 240, 4); 
AbstractVehicle abstractBike = new Motorcycle("Harley", 160, true);

Console.WriteLine("\n--- Abstract Car Actions ---");
abstractCar.Display();
abstractCar.StartEngine();
abstractCar.StopEngine();

Console.WriteLine("\n--- Abstract Bike Actions ---");
abstractBike.Display();
abstractBike.StartEngine();
abstractBike.StopEngine();