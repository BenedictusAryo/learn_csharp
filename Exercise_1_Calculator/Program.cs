using System;

namespace Exercise_1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator App");
            Console.WriteLine("");
            Console.WriteLine("Add 2 numbers");
            Console.Write("First number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            double result =  AddNumber(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} + {secondNumber} = " + result);

        }

        // Add Function
        public static double AddNumber(double firstNumber, double secondNumber){
            return firstNumber + secondNumber;
        }
    }
}
