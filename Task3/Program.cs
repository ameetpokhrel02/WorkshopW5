// --- Task 3 Demonstration: Polymorphism ---
using OOPAssignment;

Console.WriteLine("\n\n--- Task 3A: Polymorphism (Method Overloading) ---");
var printer = new Printer();
// Call all of these methods [cite: 36]
printer.Print("Hello World");
printer.Print(42);
printer.Print("Assignment Due", 3);


Console.WriteLine("\n--- Task 3B: Polymorphism (Method Overriding) ---");
// Create objects of derived classes [cite: 50]
var nepaliTeacher = new NepaliTeacher("Bikram P.");
var englishTeacher = new EnglishTeacher("Sarah K.");

// Call all its methods [cite: 50]
Console.WriteLine($"\n{nepaliTeacher.Name}:");
nepaliTeacher.Teaching(); // Calls overridden method
nepaliTeacher.SalaryInfo(); // Calls sealed base method

Console.WriteLine($"\n{englishTeacher.Name}:");
englishTeacher.Teaching(); // Calls base method
englishTeacher.SalaryInfo(); // Calls sealed base method