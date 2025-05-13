using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_SystemProject
{
    public class Reader
    {
        public string Name { get; set; }
        private List<Book> books { get; set; }
        public Reader(string name)
        {
            this.Name = name;
            this.books = new List<Book>();
        }
        public void BorrowBook(Library library, string isbn)
        {
            var searchBook = library.Books.FirstOrDefault(x => x.Isbn == isbn);
            if (searchBook != null)
            {
                library.Books.Remove(searchBook);
                books.Add(searchBook);
            }
        }
        public void ReturnBook(Library library, Book book)
        {
            library.AddBook(book);
            books.Remove(book);
        }
    }
}
