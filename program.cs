using System;

namespace MethodAssignment
{
    // Class that contains the method
    class MathClass
    {
        // Void method with two integer parameters
        public void DoMath(int num1, int num2)
        {
            // Math operation on first number
            int result = num1 * 2;

            // Display result of first number
            Console.WriteLine("First number after math: " + result);

            // Display second number
            Console.WriteLine("Second number: " + num2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create object of the class
            MathClass mathObj = new MathClass();

            // Call method normally
            mathObj.DoMath(5, 10);

            // Call method using named parameters
            mathObj.DoMath(num1: 7, num2: 20);

            Console.ReadLine();
        }
    }
}
