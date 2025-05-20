namespace P03___CarsConstruktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Cars> avtomobili = new List<Cars>();

            for (int i = 0; i < 3; i++)
            {
                var info = Console.ReadLine().Split(' ').ToList();
                var carName = info[0];
                var carModel = info[1];
                var carYear = int.Parse(info[2]);
                var carVolumeEngine = double.Parse(info[3]);
                var carPrice = double.Parse(info[4]);

                Cars car1 = new Cars(carName, carModel, carYear, carVolumeEngine, carPrice);
                avtomobili.Add(car1);
            }

           
           
           foreach (var car in avtomobili)
            {
                car.Print();
            }


        }
    }
}
