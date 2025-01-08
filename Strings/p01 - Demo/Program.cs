namespace p01___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Petar";
            Console.WriteLine(name);

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"name[{i}]={name[i]}");
            }
        }
    }
}
