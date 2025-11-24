public class BankAccount
    {
        private readonly int accountNumber;
        private double balance;

        public BankAccount(int accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.balance = 0;
            Deposit(initialBalance);
        }

        public int AccountNumber
        {
            get { return accountNumber; }
        }

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposit of {amount:C} successful. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit failed: Amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal failed: Amount must be positive.");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Withdrawal failed: Insufficient balance.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal of {amount:C} successful. Remaining balance: {balance:C}");
            }
        }
    }