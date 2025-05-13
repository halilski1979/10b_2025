namespace Delimo_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                int newNumber = Math.Abs(number);
                bool search = true;
                while (newNumber > 0)
                {
                    int digit = number % 10;
                    if (digit == 0 || number % digit != 0)
                    {
                        Console.WriteLine("No");
                        search = false;
                        break;
                    }
                    newNumber = newNumber / 10;
                }//end while
                if (search == true)
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
                Console.WriteLine("Благодаря за вниманието!");
            }
            
        }
    }
}
