namespace p06_DeleteSameNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();

            number.Add(1);
            number.Add(11);
            number.Add(5);
            number.Add(11);
            number.Add(0);
            number.Add(4);
            number.Add(11);
            number.Add(7);
            number.Add(11);

            Console.WriteLine(string.Join(" ", number));

            while (number.Contains(11))
            { 
              number.Remove(11);
            }
            Console.WriteLine(string.Join(" ", number));

            Console.WriteLine($"S={number.Sum()}");
            Console.WriteLine($"Max={number.Max()}");
            Console.WriteLine($"Min={number.Min()}");
            Console.WriteLine($"Average={number.Average()}");
            
            Console.WriteLine(string.Join(" ", number));
        }
    }
}
