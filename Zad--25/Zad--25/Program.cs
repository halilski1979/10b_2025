using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Zad__25
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                string first = Console.ReadLine();
                int result;
                if (int.TryParse(first,out result) ==false||result<0)
                {
                    throw new Exception();
                }
                string second = string.Empty;
                for (int i = first.Length - 1; i >= 0; i--)
                {
                    second += first[i];
                }
                if (first == second)
                {
                    Console.WriteLine($"{first} is a palindrome");
                }
                else
                {
                    Console.WriteLine($"{first} is NOT a palindrome");
                }
            }
			catch (Exception)
            {

                Console.WriteLine("Incorrectly entered number");
			}
        }
    }
}
