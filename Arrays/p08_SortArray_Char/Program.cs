namespace p08_SortArray_Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var symbols = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            Console.WriteLine(string.Join(" ",symbols));
            for (int i = 0; i < symbols.Length; i++)
            {
                Console.Write((int)(symbols[i]) + " ");
            }

            Console.WriteLine();
            Array.Sort(symbols);
            Console.WriteLine(string.Join(" ", symbols));
            for (int i = 0; i < symbols.Length; i++)
            {
                Console.Write((int)(symbols[i])+" ");
            }
        }
    }
}
