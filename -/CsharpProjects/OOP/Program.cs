Console.WriteLine("Hello OOP");

var p1 = new Person("Scott", "Hanselman", new DateOnly(1970,1,1));
var p2 = new Person("David", "Fowler", new DateOnly(1969,1,1));

List<Person> people = [p1, p2];

Console.WriteLine(people.Count);

public class Person(string firstName, string LastName, DateOnly birthday)
{
    public string First {get;} = firstName;
    public string Last {get;} = LastName;
    public DateOnly Birthday {get;} = birthday;
}
