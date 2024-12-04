namespace p09___ListRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            var cheten = new List<int>();
            var necheten = new List<int>();
            var endOf7 = new List<int>();

            for (int i = 0; i < num.Count; i++)
            {
                if (num[i] % 2 == 0)
                {
                    cheten.Add(num[i]);
                }
                if (num[i] % 2 == 1)
                {
                    necheten.Add(num[i]);
                }
                if (num[i] % 10 == 7)
                {
                    endOf7.Add(num[i]);
                }
            }

            Console.WriteLine($"Chetni: {cheten.Count}");
            Console.WriteLine(string.Join(" ", cheten));
            Console.WriteLine($"MaxCh: {cheten.Max()}");

            Console.WriteLine($"NeChetni: {necheten.Count}");
            Console.WriteLine(string.Join(" ", necheten));

            Console.WriteLine($"END7: {endOf7.Count}");
            Console.WriteLine(string.Join(" ", endOf7));
        }
    
    }
}
