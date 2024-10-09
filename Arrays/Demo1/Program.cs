namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вход на елементи на масив от 1 ред
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("====Pechat1======");
            //Отпечатване1
            Console.WriteLine(string.Join(" ",num));

            Console.WriteLine("*******Pechat2*********");
            //Отпечатване2  =  с цикъл For
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"num[{i}]={num[i]}");
            }

            //Отпечатване3 - с foreach
            Console.WriteLine("------Pechat3------");
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }
    }
}
