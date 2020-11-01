using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a method that will Calculate the area of
            * a circle based on its radius - you can name the method AreaOfCircle
            This method will use this formula pi * r ^ 2 and return the area of type double
            The method will also accept r as a parameter
            Allow a user to input a value for r in the console using the following code:
        var radius = double.Parse(Console.ReadLine());
            When finished your output should look something like this:*/


           
            Console.Write("What is the radius of your circle?:  ");
           // var radius = double.Parse(Console.ReadLine());
            var radius = Convert.ToDouble(Console.ReadLine());
            var area = AreaOfCircle(radius);

            Console.WriteLine($"The area of a circle with a radius of {radius} is {area} ");
        }
        public static double AreaOfCircle(double r)
        {
            
            return Math.PI * r * r; ;
        }
        	
    }
}
