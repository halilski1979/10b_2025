namespace Library_SystemProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи начален брой книги: ");
            int numbers=int.Parse(Console.ReadLine());
            Library library = new Library();
            
            for (int i = 0; i < numbers; i++)
            {
                Console.Write("Име на книга: ");
                string title = Console.ReadLine();
                Console.Write("Автор: ");
                string author = Console.ReadLine();
                Console.Write("Isbn: ");
                string isbn = Console.ReadLine();
                Console.Write("Година на публикация: ");
                int prblicationYear = int.Parse(Console.ReadLine());
                Book book = new Book(title,author,isbn, prblicationYear);
                library.AddBook(book);
            }
           
            while (true)
            {
                Console.WriteLine("Изберете: 1-взема книга,2-връща книга,END-край,4-принтиране");
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                if (command == "1")
                {
                    Console.Write("Читател: ");
                    string name = Console.ReadLine();
                    Reader reader = new Reader(name);
                    Console.Write("Isbn: ");
                    string isbn = Console.ReadLine();
                    reader.BorrowBook(library, isbn);
                }
                else if (command == "2")
                {
                    Console.Write("Читател: ");
                    string name = Console.ReadLine();
                    Reader reader = new Reader(name);
                    Console.WriteLine("*Списък на книгите в библиотеката!*");
                    Console.WriteLine(library.ListBooks());
                    
                   
                }
                else if (command == "4")
                {
                    Console.WriteLine("*Списък на книгите в библиотеката!*");                   
                    Console.WriteLine(library.ListBooks());
                }
            }
        }
    }
    
}
