using System.Collections.Generic;

namespace P01___Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var nums=new List<int>() { 22, 18, 1, 7, 3, 4, 9, 6, 8, 4, 12, 9,33,40,55,23,33,22};
            Console.WriteLine(string.Join(" ",nums));

           var newNums=nums.Where(x => x%2==0).ToList();
            Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine(string.Join(" ", newNums));

            var newNums1 = nums.Where(x => x <= 10 && x%2==0).ToList();
            Console.WriteLine(string.Join(" ", newNums1));

            var newNums2=nums.Where(x=>x%3==0).ToList();
            Console.WriteLine(string.Join(" ", newNums2));

            //Сортиране на списък
            Console.WriteLine();
            nums=nums.Where(x=>x>10).OrderBy(x=>x).Select(x=>x*10).Distinct().ToList();
            Console.WriteLine(string.Join(" ", nums));

           //Заявка със Select
           

        }
    }
}
