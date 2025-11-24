// Create an object of both Car and Bike 
AbstractVehicle car = new Car();
AbstractVehicle bike = new Bike();

Console.WriteLine("\n--- Car Actions ---");
// Call Display(), StartEngine() and StopEngine() 
car.Display();
car.StartEngine();
car.StopEngine();

Console.WriteLine("\n--- Bike Actions ---");
// Call Display(), StartEngine() and StopEngine() 
bike.Display();
bike.StartEngine();
bike.StopEngine();