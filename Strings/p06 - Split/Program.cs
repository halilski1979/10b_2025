namespace p06___Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string listOfBeers = "Amstel,Kamenica.Tuborg!Heineken,Kozel Burgas";
            Console.WriteLine(listOfBeers);

            string[] beers=listOfBeers.Split(',','.').ToArray();
            foreach (var item in beers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
