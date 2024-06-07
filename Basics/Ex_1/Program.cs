/*
program to swap two integer numbers.
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output:
After Swapping :
First Number : 6
Second Number : 5
*/
using System;
namespace Ex_1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input the First Number : ");
        int firstNumber =  Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the second Number : ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        // int temp = firstNumber;
        // firstNumber = secondNumber;
        // secondNumber = temp;

        (secondNumber, firstNumber) = (firstNumber, secondNumber);

        Console.WriteLine("After Swapping :");
        Console.WriteLine($"First Number: {firstNumber}");
        Console.WriteLine($"Second Number: {secondNumber}");
    }
}
