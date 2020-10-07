using System;

namespace Assignment1
{
    public class Book
    {

        private string _title;

        public string Title
        {
            get { return _title; }
            set
            {
                if (value.Length < 2)
                    throw new ArgumentException("Title string should be atleast 2 characters long.", nameof(Title));
                _title = value;
            }
        }

        private int _pageNumber;

        public int PageNumber
        {
            get { return _pageNumber; }
            set
            {
                if (value <= 10 || value > 1000)
                    throw new ArgumentException("Page Number should be between 10 and 1000.", nameof(PageNumber));
                _pageNumber = value;
            }
        }

        private string _isbn13;

        public string Isbn13
        {
            get { return _isbn13; }
            set
            {
                if (value.Length != 13)
                    throw new ArgumentException("Isbn13 string should be exactly 13 characters long.", nameof(Isbn13));
                _isbn13 = value;
            }
        }

        public string Author { get; set; }

    }
}
