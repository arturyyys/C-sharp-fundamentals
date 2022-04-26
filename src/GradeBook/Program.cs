using System;

namespace GradeBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var numbers = new double [3];
            // numbers[0] = 12.7;
            // numbers[1] = 10.3;
            // numbers[2] = 6.11;

            // var result = numbers[0];
            // result = result + numbers[1];
            // result = result + numbers[2];
            // Console.WriteLine(result);

            var numbers = new [] { 12.7, 10.3, 6.11, 4.1 };

            // var result = numbers[0];
            // result += numbers[1];
            // result += numbers[2];
            // Console.WriteLine(result);

            var result = 0.0;
            foreach(var number in numbers)
            {
                
            }
            Console.WriteLine(result);



            if(args.Length > 0)
            {
            Console.WriteLine($"Hello, {args[0]}!");
            }
            else {
                Console.WriteLine("Hello!");
            }
        }
    }
}