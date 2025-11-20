namespace CsharpConcepts.Core.Models;

public record RecordPerson(string FirstName, string LastName)
{
    public readonly string FullName = $"{FirstName} {LastName}";
};
