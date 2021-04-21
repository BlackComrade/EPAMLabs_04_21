using System;

namespace massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 28, 5, 6, 21, 1, 8, 2, 11, 7, 81 };
            Array.Sort(arr);
            Array.ForEach(arr, Console.WriteLine);
        }
    }
}