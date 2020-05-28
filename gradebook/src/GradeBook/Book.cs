using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        //constructor
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        //methods
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        //fields
        private List<double> grades;
        private string name;

    }
}