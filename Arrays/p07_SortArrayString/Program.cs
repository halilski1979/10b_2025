namespace p07_SortArrayString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names=Console.ReadLine().Split(' ').ToArray();
            Console.WriteLine(string.Join(" ",names));

            Console.WriteLine();
            Array.Sort(names);
            Console.WriteLine(string.Join(" ", names));

            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"[{i+1}] place:{names[i]}");
            }
        }
    }
}
