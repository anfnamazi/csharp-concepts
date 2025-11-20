namespace CsharpConcepts.Core.Models;

public record RecordPerson(string FirstName, string LastName, int Age)
{
    public readonly string FullName = $"{FirstName} {LastName}";
    public readonly string Bio = $"{FirstName} {LastName} {Age}";
};
