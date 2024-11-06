namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var num=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

           Console.WriteLine(string.Join(" ",num));
           

           

            


        }
    }
}
