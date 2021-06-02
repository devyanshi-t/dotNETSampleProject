using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
           if(args.Length >0)
           { Console.WriteLine($"Hello {args[0] }!");// String interpolation
           }
           else
           {
               Console.WriteLine("Hello World");
           }
        }
    }
}
