using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = args[0];
            Console.WriteLine("Hello Rovin!" + Name);

            double[] numbers = new double[] {14.03, 18.09, 16.02, 10.09,18.21,9.09};

            var maxNum = numbers.Max();

            var SumNum = numbers.Sum();

            System.Console.WriteLine(maxNum +" "  + SumNum);

            //Console.WriteLine(numbers[0]);

            int x = 0;
            foreach(var number in numbers)
            {   
                if(number>10)
                {
                    System.Console.WriteLine("This number is greater than 10 : "+ number);
                }
                else{
                    System.Console.WriteLine("This number is shit: " + number);
                }
                System.Console.WriteLine(x+ " .  "+ number);
                x+=1;
            }

            List<double> grades = new List<double>() {23.14,45.34,78.45,56.89};

            grades.Add(42.5);

            foreach(var number in grades)
            {   
                if(number>10)
                {
                    System.Console.WriteLine("This number is greater than 10 : "+ number);
                }
                else{
                    System.Console.WriteLine("This number is shit: " + number);
                }
                System.Console.WriteLine(x+ " .  "+ number);
            }
            


            var book = new Book("");
            book.AddGrade(90.24);
            book.AddGrade(45.09);
            book.AddGrade(43.03);

            book.PrintGrade();

            var stats = book.GetStatistics();

            System.Console.WriteLine("Highest grade is:" + stats.High);
            System.Console.WriteLine("Lowest grade is: " + stats.Low);
            System.Console.WriteLine($"Average grade is: {stats.Average:N2}");


        }
    }
}
