namespace P06___BroyNaChislata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var counter = new Dictionary<double, int>();

            foreach (var item in num)
            {
                if (counter.ContainsKey(item))
                {
                    counter[item]++;
                }
                else
                {
                    counter.Add(item, 1);

                }
            }

            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
