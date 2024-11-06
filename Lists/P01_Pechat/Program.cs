namespace P01_Pechat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> days = new List<string>() {"Po","Vt","Sr","Ch" };

            Console.WriteLine(string.Join(" ",days));

            Console.WriteLine();
            for (int i = 0; i < days.Count; i++)
            {
                Console.WriteLine($"days[{i}]={days[i]}");
            }
            
            Console.WriteLine();
            foreach (var item in days)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            days.Add("Pe");
            Console.WriteLine(string.Join(" ",days));

        }
    }
}
