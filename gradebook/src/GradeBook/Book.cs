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
            result.Count = 0;

            
            for (var i=0 ;i < grades.Count; i++)
            {
                result.High = Math.Max(grades[i], result.High);
                result.Low = Math.Min(grades[i], result.Low);
                result.Average += grades[i];
                result.Count ++;
            }

            result.Average /= grades.Count;
            return result;

        }


        //fields
        private List<double> grades;
        public string Name;

    

    }
}