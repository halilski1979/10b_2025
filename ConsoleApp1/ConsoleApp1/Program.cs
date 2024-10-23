namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int lenght = num.Length;
            Console.WriteLine($"Daljina:{lenght}");

            Console.WriteLine($"MaxEl{num.Max()}");






        }
    }
}
