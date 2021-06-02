using System;
using System.Collections;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
           var x=34.1;

           System.Console.WriteLine(x);
           double [] numbers=new  double []{4.2,5.6,77.8};
           var result=0.0;
          foreach (var item in numbers)
          {
              result+=item;
          }
       
          System.Console.WriteLine(result);

         List<double> grades=new List<double>(){34.5,67.8,90.6};
          grades.Add(78.9);
          foreach (var item in grades)
          {
              result+=item;
          }
           
        
            var avg=result/grades.Count;
            System.Console.WriteLine($"avg ={avg:N1}");
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
