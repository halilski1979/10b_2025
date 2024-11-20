namespace p11___AveragePositiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ", num));
            double s = 0;
            double average = 0;
            int counter = 0;


            for (int i = 0; i < num.Count; i++)
            {
                if (num[i]>0)
                {
                    s += num[i];
                    counter++;
                }
            }

            average=s/counter;
            Console.WriteLine($"Average={average:f2}");

        }
    }
}
