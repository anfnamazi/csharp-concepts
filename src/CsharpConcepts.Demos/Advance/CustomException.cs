using CsharpConcepts.Core.Interfaces;

namespace CsharpConcepts.Demos.Advance;

class InvalidUsernameException : Exception
{
    public string? Username { set; get; }

    public InvalidUsernameException(string? username)
        : base($"{username} is Invalid username!")
    {
        Username = username;
    }

    public InvalidUsernameException(string? username, string? message)
        : base(message)
    {
        Username = username;
    }

    public InvalidUsernameException(string? username, string? message, Exception? innerException)
        : base(message, innerException)
    {
        Username = username;
    }
}

public class CustomExceptionDemo : IDemo
{
    public static void Run()
    {
        Console.WriteLine("Please enter username:");
        var userInput = Console.ReadLine();

        try
        {
            var username = GetNormalizedUsername(userInput);
            Console.WriteLine($"Username: {username}");
        }
        catch (InvalidUsernameException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static string? GetNormalizedUsername(string? userInput)
    {
        if (string.IsNullOrEmpty(userInput) || userInput.Length < 6)
        {
            // throw exception
            throw new InvalidUsernameException(userInput);
        }

        return userInput.ToLower();
    }
}
