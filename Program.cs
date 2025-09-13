using System;

namespace MathOperationApp
{
    // Define a class called MyMathClass
    class MyMathClass
    {
        // Create a void method that takes two integers as parameters
        // This method will perform a math operation on the first integer
        // and display the second integer on the screen
        public void DoMathOperation(int firstNumber, int secondNumber)
        {
            // Perform a simple math operation on the first number (multiply it by 2)
            int result = firstNumber * 2;

            // Display the result of the math operation
            Console.WriteLine("Result of math operation on first number: " + result);

            // Display the second number that was passed into the method
            Console.WriteLine("The second number is: " + secondNumber);
        }
    }

    // The Program class contains the entry point (Main method) of the console app
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate (create an object of) the MyMathClass
            MyMathClass mathObj = new MyMathClass();

            // Call the DoMathOperation method using positional parameters
            // Example: firstNumber = 5, secondNumber = 10
            mathObj.DoMathOperation(5, 10);

            // Call the DoMathOperation method using named parameters
            // Example: firstNumber explicitly set to 7, secondNumber explicitly set to 3
            mathObj.DoMathOperation(firstNumber: 7, secondNumber: 3);

            // Prevent the console window from closing immediately
            // This allows the user to see the output before exiting
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
