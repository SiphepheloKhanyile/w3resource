/*
program that prints the multiplication table of a number as input.
Test Data:
Enter the number: 5
Expected Output:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10
5 * 3 = 15
....
5 * 10 = 50
*/

using System;

namespace Ex_3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int counter = 0;

        while(counter <= 10)
        {
            Console.WriteLine($"{number} * {counter} = {number * counter}");
            counter++;
        }
    }
}
