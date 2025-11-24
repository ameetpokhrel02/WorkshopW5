public class Teacher
    {
        public string Name { get; set; }

        public Teacher(string name)
        {
            Name = name;
        }

        // Must be 'virtual' to allow derived classes to change it
        public virtual void Teaching()
        {
            Console.WriteLine($"{Name} teaches in English.");
        }
        
        // it cannot be overridden, achieving the intended effect without the keyword.
        public void SalaryInfo()
        {
            Console.WriteLine($"{Name}'s salary information is confidential.");
        }
    }

    public class NepaliTeacher : Teacher
    {
        public NepaliTeacher(string name) : base(name) { }

        public override void Teaching()
        {
            Console.WriteLine($"{Name} teaches in Nepali and English.");
        }
    }

    public class EnglishTeacher : Teacher
    {
        public EnglishTeacher(string name) : base(name) { }
    }