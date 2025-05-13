namespace P11___CarsConstruktors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            // Създаване на списък от автомобили от информацията в списъка info
            List<Car> cars = new List<Car>();
            Console.Write("Broy avtomobili: ");
            int n=int.Parse(Console.ReadLine());
            
            
            for (int i = 0; i < n; i++)
            {
                var info = Console.ReadLine().Split(',').ToList();


                string brand = info[0];
                string model = info[1];
                int year = int.Parse(info[2]);
                double engineVolume = double.Parse(info[3]);
                double price = double.Parse(info[4]);

                cars.Add(new Car(brand, model, year, engineVolume, price));
            }


            Console.WriteLine();
            // Отпечатване на колите по азбучен ред на марката
            Console.WriteLine("Cars sorted by brand:");
            var sortedByBrand = cars.OrderBy(car => car.Brand).ToList();
            foreach (var car in sortedByBrand)
            {
                car.Print();
            }

            // Отпечатване на колите по цена
            Console.WriteLine("\nCars sorted by price:");
            var sortedByPrice = cars.OrderBy(car => car.Price).ToList();
            foreach (var car in sortedByPrice)
            {
                car.Print();
            }
        }
    }
}
