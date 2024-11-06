namespace P02_AddElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> days = new List<string>() { "Po", "Vt", "Sr", "Ch" };

            Console.WriteLine(string.Join(" ", days));

            //Добавя Петък на последна позциция
            days.Add("Pe");
            Console.WriteLine(string.Join(" ", days));

            days.Add("Sa");
            days.Add("Ne");
            Console.WriteLine(string.Join(" ", days));
        }
    }
}
