using System;
using Assignment1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment1UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTitleLengthInvalid()
        {
            Book book = new Book();

            book.Title = "t";

            Assert.Fail();

        }

        [TestMethod]
        public void TestTitleLengthValid()
        {
            Book book = new Book();

            book.Title = "tt";
        }

        [DataTestMethod]
        [DataRow(10)]
        [DataRow(1001)]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPageNumberInvalid(int pageNumber)
        {
            Book book = new Book();

            book.PageNumber = pageNumber;

            Assert.Fail();
        }


        [TestMethod]
        public void TestPageNumberValid()
        {
            Book book = new Book();

            book.PageNumber = 100;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsbn13Invalid()
        {
            Book book = new Book();

            book.Isbn13 = "stringFourteen";

            Assert.Fail();
        }

        [TestMethod]
        public void TestIsbn13Valid()
        {
            Book book = new Book();

            book.Isbn13 = "string13long-";
        }

        [TestMethod]
        public void TestAuthor()
        {
            Book book = new Book();

            string strToAssign = "AuthorName";

            book.Author = strToAssign;

            Assert.AreEqual(strToAssign, book.Author);

        }
    }
}
