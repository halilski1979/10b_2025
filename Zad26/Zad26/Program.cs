namespace Zad26
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                int num = i;
                while (num > 0) 
                {
                    int digit = num % 10; 
                    if (dict.ContainsKey(digit))
                    {
                        dict[digit]++;
                    }
                    else
                    {
                        dict.Add(digit, 1);
                    }
                    num /= 10;
                }
            }
            var result = dict.OrderByDescending(x => x.Value).First();
            Console.WriteLine($"Digit {result.Key} - {result.Value} times");
        }
    }
}
