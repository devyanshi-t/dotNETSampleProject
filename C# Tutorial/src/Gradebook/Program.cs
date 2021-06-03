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

           Book book= new Book("Book1");
           
           book.AddGrade(56.1);
           book.AddGrade(46.1);
           book.AddGrade(516.1);
           book.AddGrade(56.45);
           book.AddGrade(6.1);
           book.showStats();

          
        }
    }
}
