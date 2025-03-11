namespace P04___MinyorskaZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> izkopaemi = new Dictionary<string,int>();
            
            while (true)
            {
                string resource=Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }

                int quantity=int.Parse(Console.ReadLine());
                if (izkopaemi.ContainsKey(resource))
                {
                    izkopaemi[resource] += quantity;
                }
                else
                {
                    izkopaemi.Add(resource, quantity);
                }
            }

            foreach (var item in izkopaemi)
            {
                Console.WriteLine($"{item.Key}=>{item.Value}");
            }
        }
    }
}
