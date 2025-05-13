using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12___BooksKonstruktor
{
    public class Book
    {
        // Частни полета
        private string title;
        private string author;
        private int yearPublished;
        private double rating;
        private double price;

        // Конструктор по подразбиране
        public Book()
        {
            title = "Unknown";
            author = "Unknown";
            yearPublished = 2000;
            rating = 0.0;
            price = 20.0;
        }

        // Конструктор с параметри
        public Book(string title, string author, int yearPublished, double rating, double price)
        {
            this.Title = title;
            this.Author = author;
            this.YearPublished = yearPublished;
            this.Rating = rating;
            this.Price = price;
        }

        // Пропърти за достъп
        public string Title
        { 
            get { return title; } 
            set { title = value; }
        }
        public string Author 
        {
            get { return author; } 
            set { author = value; } 
        }
        public int YearPublished 
        { get 
            { return yearPublished; } 
            set { yearPublished = value; } 
        }
        public double Rating
        {
            get { return rating; }
            set { rating = value; } 
        }
        public double Price 
        {
            get 
            { return price; } 
            set { price = value; }
        }

       
        public void Print()
        {
            Console.WriteLine($"Knigata '{title}' ot {author}, izdana prez {yearPublished}, ima rating {rating}, cena: {price} lv.");
        }

        
        public string Info()
        {
            return $"Zaglavie: {title}, Avtor: {author}, Godina: {yearPublished}, Ocenka: {rating}/10, Cena: {price} lv";
        }

        
        public void IncreasePrice(double percentage)
        {
            price += price * (percentage / 100);
        }

        
        public void DecreasePrice(double percentage)
        {
            price -= price * (percentage / 100);
        }

        
        public override string ToString()
        {
            return $"Book: '{title}' by {author}, published in {yearPublished}, rating: {rating}/10, price: {price} lv.";
        }
    }
}
