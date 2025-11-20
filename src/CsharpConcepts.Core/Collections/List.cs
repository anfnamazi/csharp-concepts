using CsharpConcepts.Core.Models;

namespace CsharpConcepts.Core.Collections;

public static class CollectionList
{
    public static readonly List<int> numberList = [2, 5, 3, 1, 4, 6, 0];
    public static readonly List<string> animalList =
    [
        "Deer",
        "Sheep",
        "Cat",
        "Dog",
        "Bull",
        "Donkey",
        "Goat",
    ];

    public static readonly List<RecordPerson> recordPersonList =
    [
        new("John", "Deer", 24),
        new("John", "Apple", 43),
        new("Tim", "Walter", 32),
        new("April", "Johnson", 53),
    ];
}
