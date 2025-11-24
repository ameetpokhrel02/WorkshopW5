using OOPAssignment;
using System;
using System.Collections.Generic; 
// ... all the task execution code follows ...
// Task 2 Demonstration
Console.WriteLine();

// Create objects of both derived classes
var myCar = new Car("Honda", 180, 5);
var myMotorcycle = new Motorcycle("Yamaha", 220, false);

Console.WriteLine();
// Call the methods of base class 
myCar.Start();
myCar.DisplayInfo();
myCar.Stop();

Console.WriteLine();
// Call the methods of base class 
myMotorcycle.Start();
myMotorcycle.DisplayInfo();
myMotorcycle.Stop();