using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStats()
        {
            // arrange section - this is where you put together all your test data and arange the objects and the values that you going to use
            var book = new InMemoryBook("");
            book.AddGrade(9.4);
            book.AddGrade(2.5);
            book.AddGrade(6);

            // act section - this is where you actually invoke a method to perform a computation or a calculation
            var result = book.GetStats();

            //assert section- this is where you assert something about the value that was computed inside of act section
            Assert.Equal(5.97, result.Average, 2);
            Assert.Equal(9.4, result.High, 2);
            Assert.Equal(2.5, result.Low, 2);
            Assert.Equal('C', result.ConvertGradeToUSGrade);
            Assert.Equal("Satisfactory", result.ConvertGradeToDescr);
        
        }
        [Fact]
        public void BorderValuesAreChecked()
        {
            var book = new InMemoryBook("");

            var ex = Assert.Throws<ArgumentException>(() => book.AddGrade(-1.1));
            Assert.Contains("Invalid grade", ex.Message);
            var ex2 = Assert.Throws<ArgumentException>(() => book.AddGrade(15));
            Assert.Contains("Invalid grade", ex2.Message);
           
        }
        //[Fact]
        // public void CheckBookName()
        // {
        //    var book = new Book("");
        //     book.Name = "Computer Science grades";

        //     Assert.Equal("Computer Science grades", book.Name);
        // }
    }
}
