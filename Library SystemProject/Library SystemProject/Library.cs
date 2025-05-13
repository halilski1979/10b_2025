using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_SystemProject
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public Library() 
        { 
            this.Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }//end1
        public void RemoveBook(string isbn)
        {
            var searchBook = Books.FirstOrDefault(x => x.Isbn == isbn);
            if (searchBook != null)
            {
                Books.Remove(searchBook);
            }           
        }//end2
        public string ListBooks()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var book in Books)
            {
                sb.AppendLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.Isbn}, PublucationYear: {book.PrblicationYear}");
            }
            return sb.ToString().Trim();
        }
    }
}
