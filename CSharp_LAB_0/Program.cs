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
            
            Console.WriteLine($"number1 - {number1} and number2 - {number2}");
        }
    }
} 