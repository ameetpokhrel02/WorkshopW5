//Task 1 Demonstration
Console.WriteLine();
try
{
    // Create an object of bank Account
    var account = new BankAccount(accountNumber: 123456, initialBalance: 500.00);
    
    Console.WriteLine($"Account Created: #{account.AccountNumber}");
    Console.WriteLine($"Initial Balance: {account.Balance:C}");

    // Deposit the money
    account.Deposit(250.00);

    // Withdraw the money
    account.Withdraw(100.00);

    // Attempt invalid operations 
    account.Withdraw(1000.00); 
    account.Deposit(-50.00);   

    // Then print the remaining balance
    Console.WriteLine($"Final Remaining Balance: {account.Balance:C}");
}
catch (Exception ex)
{
    // Basic error handling 
    Console.WriteLine($"An unexpected error occurred in Task 1: {ex.Message}");
}