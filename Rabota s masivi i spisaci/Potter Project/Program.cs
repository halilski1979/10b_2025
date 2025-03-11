namespace Potter_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Vasko","Goshko","Toshko","Emi","Ani"};
            list.Remove("Ani");
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
