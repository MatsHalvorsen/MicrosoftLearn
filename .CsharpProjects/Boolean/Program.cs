using System;

string permission = "Manager";
int level = 10;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
    Console.WriteLine("Welcome, Super Admin User");
    }
    else
    { 
    Console.WriteLine("Welcome, Admin User");
    }
}
    else if (permission.Contains("Manager"))
    {
        if (level >= 20)
        {
            Console.WriteLine("Contact an Admin for acess.");
        }
            else
            {
                Console.WriteLine("You do not have sufficient privilages.");
            }
    }
    else
    {
        Console.WriteLine("You do dot have the sufficient privilages.");
    }
