// Part A: Method Overloading 
    public class Printer
    {
        // Overloaded Method 1
        public void Print(string message)
        {
            Console.WriteLine($"Printing message: {message}");
        }

        // Overloaded Method 2
        public void Print(int number)
        {
            Console.WriteLine($"Printing number: {number}");
        }

        // Overloaded Method 3
        public void Print(string message, int count)
        {
            Console.WriteLine($"Printing message '{message}' {count} times:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\t[{i + 1}] {message}");
            }
        }
    }