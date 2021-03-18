using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class Book
    {
        List<double> grades;
        public string Name;
        public Book(string name)
        {
            Name = name;
            grades = new List<double>();
        } 
         public void AddGrade(double grade)
         {
            grades.Add(grade);
         }

         public void PrintGrade(){

             foreach(var grade in grades)
             {
                 System.Console.WriteLine(grade);
             }
             
         }

         public Statistics GetStatistics()
         {
            var result = new Statistics();
            
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;


            foreach(var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average +=grade;
                
            }


            result.Average /=grades.Count;

            return result;

         }

    }
}