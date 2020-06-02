using System;
using Xunit;

namespace GradeBook.Tests
{

    public class TypeTests
    {
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Rimantas";
            var upper = MakeUpperCase(name);

            Assert.Equal("Rimantas", name);
            Assert.Equal("RIMANTAS", upper);

        }

        private string MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void Test1()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private int GetInt()
        {
            return 3;
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }

        [Fact]
        public void MakeCSharpIsPassByReference()
        {
            
            var book1 = GetBook("Book 1");
            
            GetBookSetName(ref book1, "New Name"); // by reference!

            
            Assert.Equal("New Name", book1.Name);
        }
        
        private void GetBookSetName(ref Book book, string name) // this is reference
        {
            book = new Book(name);

        }

        [Fact]
        public void CSharpIsPassByValueByDefault()
        {
            
            var book1 = GetBook("Book 1");
            
            GetBookSetName(book1, "New Name"); // by value!

            
            Assert.Equal("Book 1", book1.Name);
        }
                private void GetBookSetName(Book book, string name) // this is value
        {
            book = new Book(name);

        }

        [Fact]
        public void CanSetNameFromReference()
        {
            
            var book1 = GetBook("Book 1");
            
            SetName(book1, "New Name");

            
            Assert.Equal("New Name", book1.Name);
        }
        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void BookReturnsDifferentObjects()
        {
            // arrange section - this is where you put together all your test data and arange the objects and the values that you going to use
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // act section - this is where you actually invoke a method to perform a computation or a calculation
           

            //assert section- this is where you assert something about the value that was computed inside of act section
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }
        [Fact]
        public void TwoVarsReferenceSameObject()
        {
            // arrange section - this is where you put together all your test data and arange the objects and the values that you going to use
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // act section - this is where you actually invoke a method to perform a computation or a calculation
           

            //assert section- this is where you assert something about the value that was computed inside of act section
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }
        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
