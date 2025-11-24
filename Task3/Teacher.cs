namespace OOPAssignment
{
    [cite_start]// Part B: Method Overriding (Run-Time Polymorphism) [cite: 43]
    public class Teacher
    {
        [cite_start]// Property [cite: 44]
        public string Name { get; set; }

        public Teacher(string name)
        {
            Name = name;
        }

        // Virtual method allows derived classes to override it
        public virtual void Teaching()
        {
            [cite_start]// Base behavior [cite: 45]
            Console.WriteLine($"{Name} teaches in English.");
        }

        [cite_start]// Method that cannot be overridden by any child classes (use 'sealed' or no 'virtual') [cite: 46]
        public sealed void SalaryInfo()
        {
            Console.WriteLine($"{Name}'s salary information is confidential and cannot be overridden.");
        }
    }

    [cite_start]// Derived Class 1 [cite: 47]
    public class NepaliTeacher : Teacher
    {
        public NepaliTeacher(string name) : base(name) { }

        [cite_start]// Overrides the Teaching() method [cite: 48]
        public override void Teaching()
        {
            Console.WriteLine($"{Name} teaches in Nepali and English, focusing on cultural context.");
        }
    }

    [cite_start]// Derived Class 2 [cite: 49]
    public class EnglishTeacher : Teacher
    {
        public EnglishTeacher(string name) : base(name) { }
        
        [cite_start]// Demonstrates that it is not necessary to override the Teaching() method [cite: 49]
        // It will automatically use the base class's Teaching() method.
    }
}