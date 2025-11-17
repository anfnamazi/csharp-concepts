using CsharpConcepts.Core.Interfaces;

namespace CsharpConcepts.Demos.Advance;

record RecordPerson(string FirstName, string LastName);

public class RecordTypeDemo : IDemo
{
    public static void Run()
    {
        RecordPerson record1 = new RecordPerson("Peter", "Parker");
        RecordPerson record2 = new RecordPerson("Peter", "Parker");
        Console.WriteLine(record1 == record2);
        // cannot change properties like:
        // record1.FirstName = "John";
        RecordPerson? nullableRecord = null;
        // cannot use nullable value like:
        // Console.WriteLine(nullableRecord.FirstName);
        Console.WriteLine(nullableRecord?.LastName);
        nullableRecord = new RecordPerson("Jessica", "White");
        Console.WriteLine(nullableRecord?.FirstName);
    }
}
