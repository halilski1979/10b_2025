namespace _02_Vhod_Elementi_Po_Red
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вход на елементи ред по ред
            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"num[{i}]=");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("===================");
            Console.WriteLine(string.Join(" ",num));
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"num[{i}]={num[i]}");
            }
        }
    }
}
