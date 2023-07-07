using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week40.Book1
{
    public class Book
    {
        public string Title;
        public string Author;
        public int Year;


        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public string GetTitle()
        {
            return Title;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public int GetYear()
        {
            return Year;
        }

        public void SetTitle(string title)
        {
            Title = title;
        }

        public void SetAuthor(string author)
        {
            Author = author;
        }

        public void SetYear(int year)
        {
            Year = year;
        }


    }
}
