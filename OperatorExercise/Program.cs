using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            double radius = 20;
            var AreaOfCircle = Math.PI * radius * radius;

            {
                if ( a == 17 && b == 4)

                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

                Console.WriteLine($"What is the radius of your circle?");
                double v = double.Parse(Console.ReadLine());
                v = radius;
                Console.WriteLine($"The area of a circle is {AreaOfCircle}");

            }
        }
    }
}

