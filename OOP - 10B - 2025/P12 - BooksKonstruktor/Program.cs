namespace P12___BooksKonstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Създаване на списък от книги
            List<Book> books = new List<Book>();

            // Въвеждане на данни за книгите
            Console.Write("Kolko knigi iskate da vavedete? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nVavedete dannite za kniga {i + 1}:");

                Console.Write("Zaglavie: ");
                string title = Console.ReadLine();

                Console.Write("Avtor: ");
                string author = Console.ReadLine();

                Console.Write("Godina na izdavane: ");
                int yearPublished = int.Parse(Console.ReadLine());

                Console.Write("Ocenka (ot 0 do 10): ");
                double rating = double.Parse(Console.ReadLine());

                Console.Write("Cena na knigata: ");
                double price = double.Parse(Console.ReadLine());

                // Създаване на нова книга и добавяне в списъка
                books.Add(new Book(title, author, yearPublished, rating, price));
            }

            // Отпечатване на информация за книгите
            Console.WriteLine("\nInformaciya za knigite:");
            foreach (var book in books)
            {
                Console.WriteLine(book.Info());
            }

            // Изчисляване на общата цена на книгите
            double totalPrice = books.Sum(b => b.Price);
            Console.WriteLine($"\nObshchata cena na knigite: {totalPrice} lv.");

            // Намиране на най-скъпата и най-евтината книга
            var mostExpensiveBook = books.OrderByDescending(b => b.Price).First();
            var cheapestBook = books.OrderBy(b => b.Price).First();

            Console.WriteLine($"\nNai-skupa kniga: {mostExpensiveBook.Info()}");
            Console.WriteLine($"Nai-evtina kniga: {cheapestBook.Info()}");
        }
    }
}
