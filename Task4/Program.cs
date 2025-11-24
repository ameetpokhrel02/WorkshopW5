// --- Task 4 Demonstration: Abstraction (Abstract Vehicle) ---
Console.WriteLine("\n\n--- Task 4: Abstraction (Abstract Vehicle Hierarchy) ---");

// Create an object of both Car and Bike [cite: 63]
AbstractVehicle car = new Car();
AbstractVehicle bike = new Bike();

Console.WriteLine("\n--- Car Actions ---");
// Call Display(), StartEngine() and StopEngine() [cite: 64]
car.Display();
car.StartEngine();
car.StopEngine();

Console.WriteLine("\n--- Bike Actions ---");
// Call Display(), StartEngine() and StopEngine() [cite: 64]
bike.Display();
bike.StartEngine();
bike.StopEngine();