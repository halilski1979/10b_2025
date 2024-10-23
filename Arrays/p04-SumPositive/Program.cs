namespace p04_SumPositive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, -2, 3, -4, 5, -3, 6, 11, -22 };
            int sumPos = 0;
            int sumNeg = 0;
            
           // I начин 
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i]>0)
                {
                    sumPos += num[i];
                }
                else
                {
                    sumNeg += num[i];
                }
            }
            Console.WriteLine($"sumPos={sumPos}");
            Console.WriteLine($"sumNeg={sumNeg}");

            Console.WriteLine();
            // II начин
            sumPos = 0;
            sumNeg = 0;
            foreach (var item in num)
            {
                if (item>0)
                {
                    sumPos += item;
                }
                else
                {
                    sumNeg += item;
                }
            }
            Console.WriteLine($"sumPos={sumPos}");
            Console.WriteLine($"sumNeg={sumNeg}");


        }
    }
}
