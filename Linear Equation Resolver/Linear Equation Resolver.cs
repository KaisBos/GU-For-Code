
using System;

namespace LinearEquationResolver
{
    class LinearEquationResolver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0, enter constants:");

            Console.Write("a = "); double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = "); double b = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                Console.Write("The solution is " + (-b / a));
            }
            else
            {
                if (b == 0)
                {
                    Console.Write("The solution is all x!");
                }
                else
                {
                    Console.Write("There is no solution!");
                }
            }            
        }
    }
}