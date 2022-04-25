using System;

namespace GradeBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
            Console.WriteLine($"Hello, {args[0]}!");
            }
            else {
                System.Console.WriteLine("Hello!");
            }
        }
    }
}
