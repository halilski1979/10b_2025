namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var num=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ",num));

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"num[{i}]={num[i]}");
            }

            foreach (var element in num)
            {
                Console.WriteLine(element);
            }

        }
    }
}
