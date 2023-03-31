
using System;


namespace Gauge
{
    class Gauge
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gauge - Convert Number To Words");

            Console.Write("Your negative number (Up to 3 digits): ");
                uint num = Convert.ToUInt32(Console.ReadLine());

            uint ones = num % 10;
            uint tens_ex = num %100;
            uint tens = (num / 10) % 10;
            uint hundreds = num / 100;                                    

            string ERR = "NULL";

            if (hundreds > 0)
            {
                switch (hundreds)
                {
                    case 0:                                        break;
                    case 1:  Console.Write("One Hundred ");        break;
                    case 2:  Console.Write("Two Hundreds ");       break;
                    case 3:  Console.Write("Three Hundreds ");     break;
                    case 4:  Console.Write("Four Hundreds ");      break;
                    case 5:  Console.Write("Five Hundreds ");      break;
                    case 6:  Console.Write("Six Hundreds ");       break;
                    case 7:  Console.Write("Seven Hundreds ");     break;      
                    case 8:  Console.Write("Eight Hundreds ");     break;
                    case 9:  Console.Write("Nine Hundreds ");      break;
                    default: ERR = "ERROR";                       break;                    
                }
            }
        if (num % 1000 == 0)
        {
            Console.WriteLine("Zero");
        }
        else if (ERR == "ERROR")
        {
            Console.WriteLine("Out Of Ability");
        }  
        else                  
        {
            if ( (hundreds !=0) && (ones != 0 | tens != 0))        
            {
                Console.Write("And ");
            }        

            if (10 <= tens_ex && tens_ex < 20)
            {                
                switch (tens_ex)
                {
                    case 10: Console.Write("Ten");       break;
                    case 11: Console.Write("Eleven");    break;
                    case 12: Console.Write("Twelve");    break;
                    case 13: Console.Write("Thirteen");  break;
                    case 14: Console.Write("Fourteen");  break;
                    case 15: Console.Write("Fifteen");   break;
                    case 16: Console.Write("Sixteen");   break;
                    case 17: Console.Write("Seventeen"); break;
                    case 18: Console.Write("Eighteen");  break;
                    case 19: Console.Write("Nineteen");  break;                    
                }
            }

            if (1 < tens && tens < 10)
            {
                switch (tens)
                {
                    case 2: Console.Write("Twenty ");  break;
                    case 3: Console.Write("Thirty ");  break;
                    case 4: Console.Write("Forty ");   break;
                    case 5: Console.Write("Fifty ");   break;
                    case 6: Console.Write("Sixty ");   break;
                    case 7: Console.Write("Seventy "); break;
                    case 8: Console.Write("Eighty ");  break;
                    case 9: Console.Write("Ninety ");  break;
                }                
            }

            if (tens_ex < 10 | tens_ex >20)
            {
                switch (ones)
                {
                    case 1: Console.Write("One");   break;
                    case 2: Console.Write("Two");   break;
                    case 3: Console.Write("Three"); break;
                    case 4: Console.Write("Four");  break;
                    case 5: Console.Write("Five");  break;
                    case 6: Console.Write("Six");   break;
                    case 7: Console.Write("Seven"); break;
                    case 8: Console.Write("Eight"); break;
                    case 9: Console.Write("Nine");  break;                    
                }
            }
        } 
        }
    }
}