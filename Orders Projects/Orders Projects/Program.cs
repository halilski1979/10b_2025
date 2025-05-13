namespace Orders_Projects
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter w = new StreamWriter("orders.txt", true);
                List<Order> orders = new List<Order>();
                Console.Write("Въведете брой поръчки: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    string client = Console.ReadLine();
                    string product = Console.ReadLine();
                    int quantity = int.Parse(Console.ReadLine());
                    double price = double.Parse(Console.ReadLine());
                    Order order = new Order(client, product, quantity, price);
                    orders.Add(order);
                }
                foreach (Order order in orders)
                {
                    w.WriteLine(order.ToString());
                }
                w.Close();
                StreamReader r = new StreamReader("orders.txt");
                Console.WriteLine(r.ReadToEnd());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
