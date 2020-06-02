using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        //constructor
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        //methods
        public void AddGrade(double grade)
        {
            if (grade <= 10 && grade >= 0)
            {
            grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
        }

        public Stats GetStats()
        {
            var result = new Stats();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            for (var i=0 ;i < grades.Count; i++)
            {
                result.High = Math.Max(grades[i], result.High);
                result.Low = Math.Min(grades[i], result.Low);
                result.Average += grades[i];
            }

            result.Count = grades.Count;
            result.Average /= grades.Count;
            if(result.Average >= 5)
            {
                result.Iskaita = "Isk.";
            }
            else if(2 < result.Average && result.Average < 5)
            {
                result.Iskaita = "Neisk.";
            }
            else
            {
                result.Iskaita = "l.blogai";
            }
            return result;

        }


        //fields
        private List<double> grades;
        public string Name;

    

    }
}