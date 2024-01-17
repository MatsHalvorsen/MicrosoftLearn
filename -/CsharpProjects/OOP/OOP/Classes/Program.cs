using System;

public class Person
{
    //egenskaper (properties)
    public string Name {get; set;}
    public int Age {get; set;}

    //Constructor
    public Person (string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program 
{
    static void Main()
    {
        //Top-level statements

        //Create an instance of Person
        Person person1 = new Person ("John Wick", 27);

        //Accsess the properties of person1
        Console.WriteLine($"Name: {person1.Name}, Alder: {person1.Age}");
    }
}