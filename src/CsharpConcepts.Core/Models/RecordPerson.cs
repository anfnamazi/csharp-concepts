namespace CsharpConcepts.Core.Models;

public record RecordPerson(string FirstName, string LastName, int Age)
{
    public readonly string FullName = $"{FirstName} {LastName}";
};
