using System;

namespace CSharp_LAB_0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Number Generator [-50, 50]
            double number1, number2;
            
            Random random = new(); 
            number1 = random.NextDouble() * 100 - 50;
            number2 = random.NextDouble() * 100 - 50;
            
            double result = SquareOfDifference(number1, number2);
            Console.WriteLine($"Difference square {number1} and {number2} = {result}");
        }
        /// <summary>
        /// Calculate the square of the difference two numbers.
        /// </summary>
        /// <param name="num1"> first number.</param>
        /// <param name="num2"> second number.</param>
        /// <returns>Number difference square.</returns>
        static double SquareOfDifference(double num1, double num2)
        {
            double difference = num1 - num2;
            double square = difference * difference;
            return square;
        }
    }
} 