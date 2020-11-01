using System;

namespace OperatorExercise
{
    class Program
    {


        static void Main(string[] args)
        {

            int a = 17;
            int b = 4;
            
            int remainder =  a %  b;
            var quotient = a / b;
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");	

        }

      
    }
}
    


