namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
             int x = int.Parse(Console.ReadLine());
			}
			catch (Exception)
			{

                Console.WriteLine("Invalid input data"); ;
			}
        }
    }
}
