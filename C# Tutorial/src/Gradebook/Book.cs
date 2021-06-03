using System;
using System.Collections.Generic;
namespace Gradebook

{
     
    class Book
    {


     List<double> grades;
     private String name;
     double result;

     public Book(String name)
     {
         grades=new List<double>();
         this.name=name;

     }

     public void AddGrade(double x)
     {
        
      grades.Add(x);
     }

    public void showStats()
    {
       double highnumber=double.MinValue;

          double lownumber=double.MaxValue;
          
          foreach (var item in grades)
          {
              highnumber=Math.Max(item,highnumber);
              lownumber=Math.Min(item,lownumber);
              result+=item;
          }
           
        
            var avg=result/grades.Count;
            System.Console.WriteLine($"avg ={avg:N1}");
            System.Console.WriteLine($"low ={lownumber}");
             System.Console.WriteLine($"high ={highnumber}");

    }


    }
}