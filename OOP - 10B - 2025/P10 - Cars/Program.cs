namespace P10___Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://drive.google.com/drive/folders/1OvRbngq3Z9JrJ765Yl-MzZaJrqJpf-xf

            Car car1 = new Car();
            car1.Brand = "BMW";
            car1.Modell = "X5";
            car1.Year = 2025;
            car1.EngineVolume = 3.0;
            car1.Price = 50000;

            car1.Print();
            Console.WriteLine(car1.GetDescription());
            Console.WriteLine(car1);

            Console.WriteLine();
            car1.IncreasePrice(10);
            Console.WriteLine(car1);

            Console.WriteLine();
            car1.DecreasePrice(10);
            Console.WriteLine(car1);
        }
    }
}
