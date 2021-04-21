using System;

namespace BASCL
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            string c;
            Console.WriteLine("Hello user. \n Enter the first number");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Choose operation");
            c = Console.ReadLine();
            Console.Write("Result" + "->");
            switch (c)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    if (b == 0)
                        Console.WriteLine("invalid second number");
                    else
                        Console.WriteLine(a / b);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.ReadLine();
        }
    }
}