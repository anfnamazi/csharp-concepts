namespace CsharpConcepts.Core.Models;

public class Account
{
    public string Owner { get; set; }
    public int Balance { get; set; }

    public Account(string owner)
    {
        Owner = owner;
        Balance = 0;
    }

    public Account(string owner, int balance)
    {
        Owner = owner;
        Balance = balance;
    }
}
