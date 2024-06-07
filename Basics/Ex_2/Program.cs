/*
program to print the output of the multiplication of three numbers entered by the user.
Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6
Expected Output:
2 x 3 x 6 = 36
*/

using System;

namespace Ex_2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input the first number to multiply: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the second number to multiply: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the third number to multiply: ");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{firstNumber} x {secondNumber} x {thirdNumber} = {firstNumber * secondNumber * thirdNumber}");
    }
}
