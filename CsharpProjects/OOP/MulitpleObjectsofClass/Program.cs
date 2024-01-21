using System;

namespace ClassObject 
{
    class Employee
    {
        string? Department;

        static void Main(string[] args)
        {
            //create Employee Object
            Employee sheeran = new Employee();

            // set department for Sheeran
            sheeran.Department = "Development";
            Console.WriteLine("Sheeran: " + sheeran.Department);

            // create second object of Employee
            Employee Taylor = new Employee();

            Taylor.Department = "HR";
            Console.WriteLine("Taylor: " + Taylor.Department);
        }
    }
}