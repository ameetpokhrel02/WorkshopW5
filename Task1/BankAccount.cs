namespace OOPAssignment
{
    // Class definition: Represents a bank account, implementing the Encapsulation principle.
    public class BankAccount
    {
        // 1. Private fields (camelCase) to hold the state/data.
        // The 'readonly' keyword ensures the account number can only be set in the constructor.
        private readonly int accountNumber;
        private double balance;

        // Constructor: Initializes the object when it is created.
        public BankAccount(int accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.balance = 0;

            // Use the Deposit method for initialization to validate the initial amount.
            Deposit(initialBalance);
        }

        // 2. Public Property: AccountNumber (only get). This makes the account number READ-ONLY externally.
        public int AccountNumber
        {
            get { return accountNumber; }
        }

        // 2. Public Property: Balance (get, private set). 
        // Data protection: Only the methods inside this class (Deposit/Withdraw) can modify the balance.
        public double Balance
        {
            get { return balance; }
            private set
            {
                // Internal setter logic (can be simple, as validation is handled by methods)
                balance = value;
            }
        }

        // 3. Method: Deposit(double amount) - Defines the behavior of depositing funds.
        public void Deposit(double amount)
        {
            // Conditional logic (Week 3): Only allow positive deposits.
            if (amount > 0)
            {
                balance += amount; // Modify the private 'balance' field
                Console.WriteLine($"Deposit of {amount:C} successful. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit failed: Amount must be positive.");
            }
        }

        // 3. Method: Withdraw(double amount) - Defines the behavior of withdrawing funds.
        public void Withdraw(double amount)
        {
            // Condition 1: Check if the withdrawal amount is positive.
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal failed: Amount must be positive.");
            }
            // Condition 2: Check for sufficient balance before proceeding.
            else if (amount > balance)
            {
                Console.WriteLine("Withdrawal failed: Insufficient balance.");
            }
            // All conditions met: Perform the withdrawal.
            else
            {
                balance -= amount; // Modify the private 'balance' field
                Console.WriteLine($"Withdrawal of {amount:C} successful. Remaining balance: {balance:C}");
            }
        }
    }
}