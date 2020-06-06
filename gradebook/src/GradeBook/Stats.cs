using System;

namespace GradeBook
{
    public class Stats
    {
        public double High;
        public double Low;
        public int Count;
        public double Sum;

        public Stats()
        {
            Count = 0;
            Sum = 0;
            High = double.MinValue;
            Low = double.MaxValue;
        }

        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            High = Math.Max(number, High);
            Low = Math.Min(number, Low);
        }

        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }

        public string ConvertGradeToDescr
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 9.5:
                        return "Excellent";
                        
                    case var d when d >= 8.5:
                        return "Very Good";
                       
                    case var d when d >= 7.5:
                        return "Good";
  
                    case var d when d >= 6.5:
                        return "Highly Satisfactory";
   
                    case var d when d >= 5.5:
                        return "Satisfactory";

                    case var d when d >= 4.5:
                        return "Sufficient";
 
                    case var d when d >= 3.5:
                        return "Unsatisfactory";

                    case var d when d >= 2.5:
                        return "Poor";

                    case var d when d >= 1.5:
                        return "Very Poor";

                    default:
                    return "Completely Poor";

                }
            }
        }
            public char ConvertGradeToUSGrade
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 9.5:
                        return 'A';
                      
                    case var d when d >= 8.5:
                        return 'A';
                
                    case var d when d >= 7.5:
                       return 'B';
                      
                    case var d when d >= 6.5:
                        return 'B';
        
                    case var d when d >= 5.5:
                        return 'C';
        
                    case var d when d >= 4.5:
                        return 'C';
 
                    case var d when d >= 3.5:
                        return 'D';
                       
                    default:
                        return 'F';
                }
            }
        }


    }
}