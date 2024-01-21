using System;

namespace ClassObject;

class Dog
{
    //field
    string? breed;

    //method
    public void bark()
    {
        Console.WriteLine("WOOF WOOF!");
    }

    static void Main(string[] args) 
    {
        //create Dog object
        Dog bulldog = new Dog();

        //access breed of the dog
        bulldog.breed = "Bull Dog";
        Console.WriteLine(bulldog.breed);

        //access method of the dog
        bulldog.bark();

        Dog CockerSpaniel = new Dog();

        CockerSpaniel.breed = "Cocker Spaniel";
        Console.WriteLine(CockerSpaniel.breed);

        CockerSpaniel.bark();

    }


}
