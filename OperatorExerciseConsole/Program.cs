using System;

namespace OperatorExerciseConsole
{
    internal class Program
    {
        public static double AreaOfCircle(double r)
        {
            var circleArea = Math.PI * (r * r);

            return circleArea;
        }

        static void Main(string[] args)
        {

            var a = 17;
            var b = 4;

            var quotient = a / b; 
            var remainder = a % b;

            Console.WriteLine($"17 divided by 4 equals {quotient} with a remainder of {remainder}");

            Console.WriteLine("Give a number for the radius of a circle");

            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"The area of your circle is {AreaOfCircle(radius)}");

        }
    }
}
