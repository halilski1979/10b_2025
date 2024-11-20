namespace p09___DeleteAllElements_LikeLast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Въведете списък от цели числа и премахнете всички срещания 
             * в списъка на  последното число. 
            Елементите на списъка ще получите от единствен ред, разделени с 
            интервали.*/
             
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var lastNum = num.Last();
            Console.WriteLine($"LastN: {lastNum}");
            Console.WriteLine(string.Join(" ", num));



            while (num.Contains(lastNum))
            {
                num.Remove(lastNum);
            }

            Console.WriteLine(string.Join(" ",num));
            


        }
    }
}
