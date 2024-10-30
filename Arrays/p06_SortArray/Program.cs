namespace p06_SortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ", num));

            Console.WriteLine();
            Array.Sort(num);
            Console.WriteLine(string.Join(" ",num));

            Console.WriteLine();
            Array.Reverse(num);
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
