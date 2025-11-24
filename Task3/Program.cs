//Task 3 Demonstration: Polymorphism
Console.WriteLine();
var printer = new Printer();
// Call all of these methods 
printer.Print("Hello World");
printer.Print(42);
printer.Print("Assignment Due", 3);


Console.WriteLine();
// Create objects of derived classes 
var nepaliTeacher = new NepaliTeacher("Kushal T.");
var englishTeacher = new EnglishTeacher("Nikesh R.");

// Call all its methods 
Console.WriteLine($"\n{nepaliTeacher.Name}:");
nepaliTeacher.Teaching(); // Calls overridden method
nepaliTeacher.SalaryInfo(); // Calls sealed base method

Console.WriteLine($"\n{englishTeacher.Name}:");
englishTeacher.Teaching(); // Calls base method
englishTeacher.SalaryInfo(); // Calls sealed base method