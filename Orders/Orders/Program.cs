namespace Orders
{
    using System.IO;
    public class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string ClientName = Console.ReadLine();
                string ProductName = Console.ReadLine();
                int Quantity = int.Parse(Console.ReadLine());
                double Price = double.Parse(Console.ReadLine());
                Order order = new Order(ClientName,ProductName,Quantity,Price);
                orders.Add(order);
            }
            StreamWriter sw = new StreamWriter("order.txt", true);
            foreach (Order order in orders) 
            {
               sw.WriteLine(order.ToString());
            }
            sw.Close();
            Console.WriteLine("Списък от поръчки: ");
            var text = File.ReadAllLines("order.txt");
            foreach (string line in text)
            {
                Console.WriteLine(line);
            }
            
        }
    }
}
