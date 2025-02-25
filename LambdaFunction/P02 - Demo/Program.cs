namespace P02___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int>() { -1, 2 ,- 3, 4, - 5, 6, 7, 8, 9 };
            Console.WriteLine(string.Join(" ",nums));

           var newNums= nums.Where(x => x % 2 == 0 && x>5).ToList();
            Console.WriteLine(string.Join(" ", newNums));

          nums.OrderBy(x=>x).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
