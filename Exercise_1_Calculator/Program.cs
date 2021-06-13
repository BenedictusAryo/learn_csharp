using System;

namespace Exercise_1_Calculator
{
    class Program
    {
        static void Main()
        {
            string[] allowedOper = new string[4] {"+", "-", "*", "/"};
            string type;
            double firstNumber;
            double secondNumber;
            double answer;
            string restartCheck;

            Console.WriteLine("Calculator App");
            Console.WriteLine("");
            Console.WriteLine("Type Calculation to perform? (+, -, *, /)");
            type = GetCalcType(allowedOper);

            // Get firstNumber            
            Console.Write("First number: ");
            firstNumber = GetCalcNum();

            // Get secondNumber            
            Console.Write("Second number: ");
            secondNumber = GetCalcNum();

            // Run Calculation
            answer = Calculate(firstNumber, secondNumber, type);

            // Write the answer
            Console.WriteLine("The answer is " + answer + "\r\n Write 'yes' to restart application.");

            // Check if the user wants to restart the calculator
            restartCheck = Console.ReadLine();
            if (restartCheck == "yes")
            {
                Main();
            }
            else
            {
                Environment.Exit(0);
            }

           

            

        }

        // Calculate
        public string GetCalcType(string[] allowedOper)
        {
            // Get the operator
            string type = Console.ReadLine();
            
            // Check if valid operator is selected
            while (!allowedOper.Contains(type))
            {
                Console.WriteLine("Choose a valid operator type!");
                type = Console.ReadLine();
            }
            return type;
        }

        // Get number
        private int GetCalcNum()
        {
            int num;
            // Checking if parse successfull
            bool parseCheck = double.TryParse(Console.ReadLine(), out num);

            // As long as boolean is false, keel loop the input
            while (!parseCheck)
            {
                Console.WriteLine("Try again with actual numbers..")
                parseCheck = double.TryParse(Console.ReadLine(), out num);

            }
            return num;
        }

        // Add Function
        public static double AddNumber(double firstNumber, double secondNumber){
            return firstNumber + secondNumber;
        }
    }
}
