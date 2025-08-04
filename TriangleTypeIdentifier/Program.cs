using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Triangle Type Identifier!");

        Console.Write("Enter length of side 1: ");
        int side1 = int.Parse(Console.ReadLine());

        Console.Write("Enter length of side 2: ");
        int side2 = int.Parse(Console.ReadLine());

        Console.Write("Enter length of side 3: ");
        int side3 = int.Parse(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("This is an Equilateral triangle.");
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            Console.WriteLine("This is an Isosceles triangle.");
        }
        else
        {
            Console.WriteLine("This is a Scalene triangle.");
        }
    }
}
