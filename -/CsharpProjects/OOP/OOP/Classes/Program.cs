using System;

public class Person
{
    //egenskaper (properties)
    public string Name {get; set;}
    public int Age {get; set;}
    public string Occupation {get; set;}

    //Constructor
    public Person (string name, int age, string occupation)
    {
        Name = name;
        Age = age;
        Occupation = occupation;
    }
}

class Program 
{
    static void Main()
    {
        //Top-level statements

        //Create an instance of Person
        Person person1 = new Person ("John Wick", 27, "Dog owner");

        //Accsess the properties of person1
        Console.WriteLine($"Name: {person1.Name}, Alder: {person1.Age}, Yrke: {person1.Occupation}");
    }
}