using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Calculator Project with C#");
            
            //asking for a number and converting it to a double
            Console.Write("Please enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
        }
    }
}
