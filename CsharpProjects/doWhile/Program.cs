using System;
/*
Random random = new Random();
int current = 0;

do 
{
    current = random.Next(1,11);
    Console.WriteLine(current);
} while (current != 7);


Random random = new Random();
int current = random.Next(1,11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1,11);
}
Console.WriteLine($"Last number: {current}");


Random random = new Random();
int current = random.Next(1,11);

do
{
    current = random.Next(1,11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);
*/
/*
Random randomAttack = new Random();

int heroHealth = 10;
int monsterHealth = 10;

do
{
    int attack = randomAttack.Next(1,11);
    monsterHealth -= attack;
    Console.WriteLine($"Monster was dameged and lost {attack} health and has now {monsterHealth} health.");

    if (monsterHealth <= 0) continue;

    attack = randomAttack.Next(1,11);
    heroHealth -= attack;
    Console.WriteLine($"Hero was dameged and lost {attack} health and has now {heroHealth} health.");

}while (heroHealth > 0 && monsterHealth > 0);
Console.WriteLine(heroHealth > monsterHealth ? "Hero wins": "Monster wins");
*/

//Code project 1 - write code that validates integer input
/*
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

//validEntry = int.TryParse(readResult, out numericValue);

Console.WriteLine("choose an integer between 5 and 10");
do
{
    readResult = Console.ReadLine();
    if (readResult != 0)
    {
        valueEntered = readResult;
    }
    validNumber = int.TryParse(valueEntered, out numValue)

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a value between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number Try again.");
    }
} while (validNumber == false)

    Console.WriteLine($"Your inputvalue ({numValue}) has been accepted");

    readResult = Console.ReadLine();
*/

//Code Project 2
string userInput = "";
bool validInput = false;
string? readResult;


do
{   
    Console.WriteLine("Choose one of three roles: Administor, Manager, or User.");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        userInput = readResult.Trim();
    }
    if (userInput.ToLower() == "administrator" || userInput.ToLower() == "manager" || userInput.ToLower() == "user")
    {
        validInput = true;
    }
    else 
    {
        Console.WriteLine("Unvalid entry. Try again.");
    }
} while (validInput == false);

Console.WriteLine("Your value has been accepted");

readResult = Console.ReadLine();
