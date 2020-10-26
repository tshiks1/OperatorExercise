using System;

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

            Console.WriteLine($"{a}/{b} is { quotient} remainder {remainder}");
        }
        /*For division, create two integer variables called a and b. 
Create a third integer variable and name it quotient (the result of a division) 
        that stores the result of the division of a and b, 
        and another integer variable named remainder
        that stores the remainder (using the % operator). 
        Write out the results using Console.WriteLine or Console.Write to 
        write out the results in the following form: if a = 17 and b = 4, print the following:	
17/4 is 4 remainder 1	*/		
    }
}
