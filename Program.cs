﻿using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            var product = a * b;

            Console.WriteLine($"{a}/{b} is { quotient} remainder {remainder}");
            Console.WriteLine($"{a}*{b} is { product} remainder {remainder}");
        }
        
    }
}
