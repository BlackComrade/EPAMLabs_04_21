using System;

namespace basic_calculator 
{
    class Program
    {
        static void Main(string[] args)
        {
            float first_number, second_number;
            string sign;
            Console.WriteLine("Hello user. \n Enter the first number");
            first_number = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            second_number = float.Parse(Console.ReadLine());
            Console.WriteLine("Choose operation");
            sign  = Console.ReadLine();
            Console.Write("Result" + "->");
            switch (sign )
            {
                case "+":
                    Console.WriteLine(first_number + second_number);
                    break;
                case "-":
                    Console.WriteLine(first_number - second_number);
                    break;
                case "*":
                    Console.WriteLine(first_number * second_number);
                    break;
                case "/":
                    if (second_number == 0)
                        Console.WriteLine("invalid second number");
                    else
                        Console.WriteLine(first_number / second_number);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.ReadLine();
        }
    }
}
