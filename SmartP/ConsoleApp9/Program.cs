namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Smartphone> smartphones = new List<Smartphone>();
            Console.WriteLine("Number of phones:");
            int numberOfPhones = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPhones; i++)
            {
                var info = Console.ReadLine().Split(',').ToList();

                string brand = info[0];
                string model = info[1];
                int releaseYear = int.Parse(info[2]);
                int storage = int.Parse(info[3]);
                double price = double.Parse(info[4]);

                smartphones.Add(new Smartphone {Brand = brand, Model = model, ReleaseYear = releaseYear, Storage = storage, Price = price});
            }

            Console.WriteLine();

            Console.WriteLine("Phones sorted alphabetically by brand:")
            var sortedByBrand = smartphones.OrderBy(smartphones =>  smartphones.Brand).ToList();
            foreach (Smartphone item in smartphones)
            {
                item.Print();
            }
        }
    }
}
