namespace P03_AddElements_EdinRed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ",num));
            Console.WriteLine();

            num.Add(100);
            num.Add(101);
            num.Add(102);
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
