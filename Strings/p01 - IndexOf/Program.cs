namespace p01___IndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IndeXOf - връща номера на символа
            
            string word = "Continenti";
            int firstSymbol = word.IndexOf("ti");
            int lastSymbol = word.LastIndexOf("ti");

            Console.WriteLine(firstSymbol);
            Console.WriteLine(lastSymbol);


            Console.WriteLine();

        }
    }
}
