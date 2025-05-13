using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_SystemProject
{
    public class Book
    {
        public Book(string title, string author, string isbn, int prblicationYear)
        {
            this.Title = title;
            this. Author = author;
            this. Isbn = isbn;
            this.PrblicationYear = prblicationYear;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public int PrblicationYear { get; set; }
    }
}
