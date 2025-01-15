namespace p04___Remove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = "0123456789";
            Console.WriteLine(numbers);

            string newNumbers1 = numbers.Remove(3);
            Console.WriteLine(newNumbers1);

            string newNumbers2 = numbers.Remove(4,2);
            Console.WriteLine(newNumbers2);
        }
    }
}
