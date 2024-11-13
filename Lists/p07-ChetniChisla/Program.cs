namespace p07_ChetniChisla
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

            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] %2==1)
                {
                    Console.WriteLine(number[i]);
                }
            }
        }
    }
}
