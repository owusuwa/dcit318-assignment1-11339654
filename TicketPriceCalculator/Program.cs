using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Ticket Price Calculator!");

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age <= 18 || age >= 45)
        {
            Console.WriteLine("Ticket price: GHC7");
        }
        else
        {
            Console.WriteLine("Ticket price: GHC10");
        }
    }
}

