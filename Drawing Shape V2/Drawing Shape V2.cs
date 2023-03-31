
using System;


namespace Drawing_Shape_V2
{
    class Drawing_Shape_V2
    {
        static void Main(string[] args)
        {   
            int choice = -6;
            while (choice != 0)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Print the rectangle");
                Console.WriteLine("2. Print the square triangle");
                Console.WriteLine("3. Print the isosceles triangle");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        for (int i = 1; i <= 3; i++)
                        {
                            for (int j = 1; j <= 6; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("The corner is square at which angle?");
                        Console.WriteLine("(Choices: top-left, top-right, bottom-left, bottom-right)");
                        string angle = Console.ReadLine();
                        switch (angle)
                        {
                            case "top-left":
                            {
                                for (int i = 4; i >= 1; i--)
                                {                                    
                                    for (int j = 1; j <= i; j++)
                                    {
                                        Console.Write("* ");
                                    }
                                    Console.WriteLine();
                                }
                                break;
                            }       
                            case "top-right":
                            {
                                int space = 1;
                                for (int i = 4; i >= 1; i--)
                                {
                                    for (int j = 1; j <= i; j++)
                                    {                                        
                                        Console.Write("* ");
                                    }
                                    Console.WriteLine();            
                                    for (int k = 1; k <= space ; k++)
                                    {
                                        Console.Write("  ");
                                    }
                                    space++;                        
                                }
                                Console.WriteLine();
                                break;
                            }   
                            case "bottom-left":
                            {
                                for (int i = 1; i <= 4; i++)
                                {
                                    for (int j = 1; j <= i; j++)
                                    {
                                        Console.Write("* ");
                                    }
                                    Console.WriteLine();
                                }
                                break;
                            }   
                            case "bottom-right":
                            {
                                int space = 3;
                                for (int i = 1; i <=4; i++)
                                {
                                    for (int k = 1; k <= space; k++)
                                    {
                                        Console.Write("  ");
                                    }
                                    space--;
                                    for (int j = 1; j <= i; j++)
                                    {
                                        Console.Write("* ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();
                                break;
                            } 
                            default:
                                Console.WriteLine("Invalid Choice!");
                                break;
                        }
                        break;
                    case 3:
                        int space_n = 3;                        
                        int dots = 1;
                        for (int i = 1; i <=4; i++)
                        {
                            for (int k = 1; k <= space_n; k++)
                            {
                                Console.Write("  ");
                            }
                            space_n--;
                            for (int j = 1; j <= dots; j++)
                            {
                                Console.Write("* ");
                            }
                            dots += 2;   
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid!");
                        break;
                }
            }
        }   
    }
}