namespace p03_BroyElementi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, -2, 3, -4, 5, -3, 6, 11, -22 };
            int positive = 0;
            int negative = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i]<0)
                {
                    negative++;
                }
                else if (num[i] > 0)
                {
                    positive++;
                }
            }

            Console.WriteLine(string.Join(" ",num));
            Console.WriteLine($"Positive: {positive}");
            Console.WriteLine($"Negative: {negative}");
        }
    }
}
