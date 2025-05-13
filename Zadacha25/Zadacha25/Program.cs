namespace Zadacha25
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                string number = Console.ReadLine();
                int result;
                if (!int.TryParse(number,out result))
                {
                    throw new Exception();
                }
                if (int.Parse(number)<0)
                {
                    throw new Exception();
                }
                string rightNumber = string.Empty;
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    rightNumber += number[i];
                }
                if (number == rightNumber)
                {
                    Console.WriteLine($"{number} is a palindrome");
                }
                else
                {
                    Console.WriteLine($"{number} is NOT a palindrome");
                }
            }
			catch (Exception)
			{

                Console.WriteLine("Incorrectly entered number");
			}
        }
    }
}
