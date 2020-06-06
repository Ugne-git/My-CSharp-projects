using System;
using System.Collections.Generic;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args); //defining event
    

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
           

            for (var i=0 ;i < grades.Count; i++)
            {
                result.Add(grades[i]);
            
            }
           
            return result;

        }

        //fields
        public override event GradeAddedDelegate GradeAdded;// adding delegate event field
        private List<double> grades;
        
    }
}