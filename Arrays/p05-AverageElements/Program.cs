namespace p05_AverageElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Средно аритметично

            int[] number = { 1, -2, 3, -4, 5, -6, 7, -8, 1};
            int positiveCounter = 0;
            int positiveSum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > 0)
                {
                    positiveCounter++;
                    positiveSum += number[i];
                }
            }

            Console.WriteLine($"Average - {(double)positiveSum /(double)positiveCounter}");
        }
    }
}
