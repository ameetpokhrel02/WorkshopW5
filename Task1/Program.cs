// Use this line to allow Program.cs to find classes like BankAccount, Car, etc.
using OOPAssignment;
using System; 
// Using Top-Level Statements for simplicity (as per Week 2 slides).

Console.WriteLine("--- Assignment 5 Solution ---");

// --- Task 1 Demonstration (Paste the Task 1 code here) ---
Console.WriteLine("--- Task 1: Encapsulation (BankAccount) ---");
try
{
    // Create an object of bank Account
    var account = new BankAccount(accountNumber: 123456, initialBalance: 500.00);

    // ... rest of the Task 1 code ...
    Console.WriteLine($"Account Created: #{account.AccountNumber}");
    Console.WriteLine($"Initial Balance: {account.Balance:C}");

    // Deposit the money
    account.Deposit(250.00);

    // Withdraw the money
    account.Withdraw(100.00);

    // Attempt invalid operations (demonstrates encapsulation)
    account.Withdraw(1000.00); 
    account.Deposit(-50.00);   

    // Then print the remaining balance
    Console.WriteLine($"Final Remaining Balance: {account.Balance:C}");
}
catch (Exception ex)
{
    // Basic error handling as per Week 3 slides
    Console.WriteLine($"An unexpected error occurred in Task 1: {ex.Message}");
}


// --- Task 2 Demonstration (Paste the Task 2 code here) ---
/* ... all other task code goes here ... */