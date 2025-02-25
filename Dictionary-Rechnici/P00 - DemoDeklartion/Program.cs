namespace P00___DemoDeklartion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];

            Dictionary<string, int> people = new Dictionary<string, int>();
            var persons= new Dictionary<string, int>();

            num[0] = 1;
            num[1] = 22;

            //Добавяне на елементи към речник
            people["Ivan"] = 23;
            people["Petar"] = 32;
            people.Add("Asen",44);
            people.Add("Kiril",18);

            //В речник няма елементи с еднакъв ключ
            //people.Add("Kiril", 33);

            //Отпечатване
            foreach (var item in people)
            {
                Console.WriteLine($"{item.Key} is  {item.Value} years old!");
            }



        }
    }
}
