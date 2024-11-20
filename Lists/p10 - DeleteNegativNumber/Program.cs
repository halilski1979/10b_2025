namespace p10___DeleteNegativNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Въведете списък от цели числа, премахнете всички отрицателни 
             * числа от него и го изведете на конзолата в обратен ред.*/

            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ",num));

            var result=new List<int>();

            for (int i = 0; i < num.Count; i++)
            {
                if (num[i]>=0)
                {
                    result.Add(num[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
