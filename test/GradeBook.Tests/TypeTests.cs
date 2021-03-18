using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        
        [Fact]
        public void Test1()
        {
            var x = GetInt();

            SetInt(x);
            Assert.Equal(x,3);
        }

         private int GetInt()
        {
            return 3;
        }

        private void SetInt(int x)
        {
            x = 42;
        }

       [Fact]
        public void PassByReference()
        {
            var book1 = GetBook("Book 1");
            GetBookSetNameRef(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);

        }

        private void GetBookSetNameRef(ref Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }

        [Fact]
        public void PassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Same("New Name", book1.Name);

        }

        private void GetBookSetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Same("New Name", book1.Name);

        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }
        [Fact]
        public void GetBookReturnsDifferentObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("sonavabich");


            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("sonavabich", book2.Name);
            Assert.NotSame(book1, book2);

        }

        [Fact]
        public void SameReference()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;
            var book3 = GetBook("Book 2");

            Assert.Equal("Book 1", book2.Name);
            Assert.Same(book2.Name, book1.Name);
            Assert.True(Object.ReferenceEquals(book1.Name, book2.Name));

        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
        

    }
}
