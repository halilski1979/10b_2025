namespace Zadacha25b
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                int number=int.Parse(Console.ReadLine());
                int newNumber=number;
                bool search=false;
                while (newNumber > 0) 
                {
                    int tempNumber = newNumber % 10;
                    if (number%tempNumber!=0||tempNumber==0)
                    {
                        Console.WriteLine("No");
                        search = true;
                        break;
                    }
                    newNumber = newNumber / 10;
                }
                if (search==false) 
                {
                    Console.WriteLine("Yes");
                }
			}
			catch (Exception)
			{

                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                Console.WriteLine("ПАК ЗАПОВЯДАЙТЕ!!!");
            }
        }
    }
}
