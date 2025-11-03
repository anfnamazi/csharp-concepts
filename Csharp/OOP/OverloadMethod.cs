using Csharp.Models;

namespace Csharp.OOP;

public class OverloadMethodDemo
{
    public static void Run()
    {
        Account account = new Account("test", 2);
        Console.WriteLine($"Owner: {account.Owner}, Balance: {account.Balance}");
    }
}