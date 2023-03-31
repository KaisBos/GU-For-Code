
using System;

namespace LinearEquationResolver
{
    class LinearEquationResolver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Body mass index-BMI");

            Console.Write("Your weight (kg): ");
                double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Your height (m): ");
                double height = Convert.ToDouble(Console.ReadLine());

            double BMI = weight / Math.Pow(height,2);
            BMI = Math.Round(BMI,1);

            if (BMI < 18.5)
            {
                Console.WriteLine("You are Underweight!");
            }
            else if (BMI < 25.0)
            {
                Console.WriteLine("You are Normal!");
            }
            else if (BMI < 30.0)
            {
                Console.WriteLine("You are Overweight!");
            }
            else
            {
                Console.WriteLine("You are Obese!");
            }
        }
    }
}