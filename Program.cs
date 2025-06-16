namespace Generics;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // List<Object> objects = ["fish", 5, 6, 7, true];
        // Eksempel på en objektliste


        // TypeChecker("Hello");
        // TypeChecker(true);
        TypeChecker(3.14.ToString(CultureInfo.InvariantCulture));
        // TypeChecker(42);

        BetterList<int> betterNumbers = new();
        betterNumbers.AddToList(125);

        BetterList<string> betterStrings = new BetterList<string>();
        betterStrings.AddToList("Hello");

        BetterList<PersonRecord> people = new BetterList<PersonRecord>();
        people.AddToList(new("Ola", "Nordmann"));


    }

    public static void TypeChecker<T>(T value)
    {
        Console.WriteLine("Type: " + typeof(T));
        Console.WriteLine("Value: " + value);
    }

    public class BetterList<T>
    {
        private List<T> data = [];

        public void AddToList(T value)
        {
            data.Add(value);
            Console.WriteLine($"{value} has been added to the list");
        }

    }
    record PersonRecord(string FirstName, string LastName);
}
