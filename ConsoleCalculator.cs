using System;

namespace Calculator
{
    public static class ConsoleCalculator
    {
        public static void Add(double first, double second) {
            Console.WriteLine($"Add called with arguments, first: {first}; second: {second}");
            Console.WriteLine($"Result: {Calculator.Add(first, second)}");
        }

        public static void Subtract(double first, double second) {
            Console.WriteLine($"Add called with arguments, first: {first}; second: {second}");
            Console.WriteLine($"Result: {Calculator.Subtract(first, second)}");
        }

        public static void Multiply(double first, double second) {
            Console.WriteLine($"Add called with arguments, first: {first}; second: {second}");
            Console.WriteLine($"Result: {Calculator.Multiply(first, second)}");
        }

        public static void Divide(double first, double second) {
            Console.WriteLine($"Add called with arguments, first: {first}; second: {second}");
            Console.WriteLine($"Result: {Calculator.Divide(first, second)}");
        }
    }
}