using System;
using System.Collections.Generic;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args); //defining event
    
    public interface IBook
    {
        void AddGrade(double grade);
        Stats GetStats();
        string Name { get; }
        event GradeAddedDelegate GradeAdded;
    }

    // book is inherited from NamedObject, it means Book is a NamedObject
    public class InMemoryBook : Book
    {
        //constructor
        public InMemoryBook(string name) : base("")
        {
            grades = new List<double>();
            Name = name;
        }
        //methods
        public override void AddGrade(double grade)
        {
            if (grade <= 10 && grade >= 0)
            {
            grades.Add(grade);
            if(GradeAdded != null)
            {
                GradeAdded(this, new EventArgs()); // invoking event
            }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }


        public override Stats GetStats()
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

           switch(result.Average)
           {
                case var d when d >= 9.5:
                    result.GradeDescr = "Excellent";
                    result.USGrade = 'A';
                    break;
                case var d when d >= 8.5:
                    result.GradeDescr = "Very Good";
                    result.USGrade = 'A';
                    break;
                case var d when d >= 7.5:
                    result.GradeDescr = "Good";
                    result.USGrade = 'B';
                    break;
                case var d when d >= 6.5:
                    result.GradeDescr = "Highly Satisfactory";
                    result.USGrade = 'B';
                    break;
                case var d when d >= 5.5:
                    result.GradeDescr = "Satisfactory";
                    result.USGrade = 'C';
                    break;
                case var d when d >= 4.5:
                    result.GradeDescr = "Sufficient";
                    result.USGrade = 'C';
                    break;
                case var d when d >= 3.5:
                    result.GradeDescr = "Unsatisfactory";
                    result.USGrade = 'D';
                    break;
                case var d when d >= 2.5:
                    result.GradeDescr = "Poor";
                    result.USGrade = 'F';
                    break;
                case var d when d >= 1.5:
                    result.GradeDescr = "Very Poor";
                    result.USGrade = 'F';
                    break;
                case var d when d >= 0.5:
                    result.GradeDescr = "Completely Poor";
                    result.USGrade = 'F';
                    break;
                default:
                    break; 
           }

            return result;

        }

        //fields
        public override event GradeAddedDelegate GradeAdded;// adding delegate event field
        private List<double> grades;
        
    }
}