namespace P01___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Полета и създаване на клас
            
            Person p=new Person();
            p.name = "Ivan";
            p.age = 22;
            p.klass = 10;
            p.uspeh = 5.34;

            Console.WriteLine($"Ime: {p.name}. {p.age} godini.{p.klass} klas v uchilishte. Uspeh {p.uspeh}");


        }
    }
}
