namespace _01_VhodElementi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вход на елементи от 1 ред
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(",",num));

           
        }
    }
}
