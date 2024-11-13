namespace p05___ArraysMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>();

            number.Add(1);
            number.Add(11);
            number.Add(5);
            number.Add(11);
            number.Add(0);        
            number.Add(4);
            number.Add(11);
            number.Add(7);
            number.Add(11);

            Console.WriteLine(string.Join(" ",number));

            //Връща броя на елементи
            Console.WriteLine($"Broy elementi: {number.Count}");

            //Remove - изтрива първи срещнат елемент
            number.Remove(11);
            Console.WriteLine(string.Join(" ", number));

            //RemoveAt - изтрива елемент по индекс
            number.RemoveAt(0);
            Console.WriteLine(string.Join(" ", number));

            //Insert(index,element)-вмъква елемент на дадена позиция
            number.Insert(2,111);
            Console.WriteLine(string.Join(" ", number));

            //Sort()  - сортира във възходящ ред
            number.Sort();
            Console.WriteLine(string.Join(" ", number));

            //Reverse()  - обръща списъка наобратно
            number.Reverse();
            Console.WriteLine(string.Join(" ", number));

            //Countains()  - определя дали елемент се съдържа в списъка            
            Console.WriteLine(number.Contains(0));
        }
    }
}
