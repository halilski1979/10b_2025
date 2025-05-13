namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = a / b;
                Console.WriteLine(result);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Невалидни входни данни!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.WriteLine("Благодаря за вниманието!");
            }

        }
    }
}
