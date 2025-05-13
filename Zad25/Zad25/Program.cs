namespace Zad25
{
    public class Program
    {
        static void Main(string[] args)
        {
			try
			{
                int number = int.Parse(Console.ReadLine());
                int newNumber = Math.Abs(number);
                bool search = false;
                while (newNumber > 0)
                {
                    int digit = newNumber % 10;
                    if (digit==0|| number % digit != 0)
                    {
                    
                        search = true;
                        break;
                    }
                    newNumber = newNumber / 10;
                }
                if (search == false)
                {
                    Console.WriteLine("Yes");
                }
                else 
                {
                    Console.WriteLine("No");
                }
            }
			catch (Exception)
			{

                Console.WriteLine("Something went wrong!");
			}
        }        
    }
}
