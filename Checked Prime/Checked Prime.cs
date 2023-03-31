
using System;


namespace Checked_Prime
{
    class Checked_Prime
    {
        static void Main(string[] args)
        {            
            Console.Write("Enter your number: ");
                int number = Int32.Parse(Console.ReadLine());

            int check = 1;
            bool prime = true;


            while (check < Math.Sqrt(number))
            {
                check++;
                if (number % check == 0)
                {
                    prime = false;
                    break;
                }                
            }

            if (number == 2 | (prime && number != 1 && number > 2))
            {
                Console.WriteLine("{0} is a prime", number);
            }
            else
            {
            Console.Write("{0} isn't a prime", number);
            }
        }   
    }
}