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
            grades.Add(grade);
        }

        public Stats GetStats()
        {
            var result = new Stats();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach(var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }

            result.Average /= grades.Count;
            return result;

        }

        //fields
        private List<double> grades;
        public string Name;

    }
}