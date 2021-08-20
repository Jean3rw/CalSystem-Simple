using System;

namespace SimpleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This system calculates the sum of two numbers");
            Console.WriteLine("Enter the first Number: ");
            int num1 = Console.Read();

            Console.WriteLine("Enter Second Number: ");
            int num2 = Console.Read();

            if (num1 + num2 > 0)
            {
                int Call = num1 + num2;
                Console.WriteLine("The Sum is= " + Call);
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine("This is an change made");

        }
    }
