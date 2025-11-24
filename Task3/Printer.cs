namespace OOPAssignment
{
    // Part A: Method Overloading (Compile-Time Polymorphism) [cite: 34]
    public class Printer
    {
        // Overloaded Method 1: Print(string message) [cite: 35]
        public void Print(string message)
        {
            Console.WriteLine($"Printing message: {message}");
        }

        // Overloaded Method 2: Print(int number) [cite: 35]
        public void Print(int number)
        {
            Console.WriteLine($"Printing number: {number}");
        }

        // Overloaded Method 3: Print(string message, int count) [cite: 35]
        public void Print(string message, int count)
        {
            Console.WriteLine($"Printing message '{message}' {count} times:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\t[{i + 1}] {message}");
            }
        }
    }
}