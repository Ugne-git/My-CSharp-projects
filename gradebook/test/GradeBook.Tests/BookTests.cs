using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            // arrange section - this is where you put together all your test data and arange the objects and the values that you going to use
            var book = new Book("");
            book.AddGrade(9.4);
            book.AddGrade(2.5);
            book.AddGrade(6);

            // act section - this is where you actually invoke a method to perform a computation or a calculation
            var result = book.GetStats();

            //assert section- this is where you assert something about the value that was computed inside of act section
            Assert.Equal(5.97, result.Average, 2);
            Assert.Equal(9.4, result.High, 2);
            Assert.Equal(2.5, result.Low, 2);
        
        }
    }
}
