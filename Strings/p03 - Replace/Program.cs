namespace p03___Replace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coctail = "Vodka + Martini + Cherry";
            Console.WriteLine(coctail);

            string newCoctail = coctail.Replace('o','0');
            Console.WriteLine(newCoctail);

            string newCoctail2 = newCoctail.Replace('i','1');
            Console.WriteLine(newCoctail2);

            string newCoctail3 = newCoctail2.Replace("+","and");
            Console.WriteLine(newCoctail3);
            
        }
    }
}
