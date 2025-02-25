namespace P02___DemoAddElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students=new Dictionary<string, double>();

            Console.Write("Broy uchenici: ");
            int br=int.Parse(Console.ReadLine());

            for (int i = 0; i < br; i++)
            {
                var school = Console.ReadLine().Split(' ').ToList();
                var name=school[0];
                var money=double.Parse(school[1]);

                if (students.ContainsKey(name))
                {
                    students[name] += money;
                }
                else 
                { 
                  students.Add(name, money);
                }
            }

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }


        }
    }
}
