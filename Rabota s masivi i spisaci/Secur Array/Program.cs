namespace Secur_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ").ToList();
            var command = Console.ReadLine().Split(' ').ToList();
            while (command[0] != "END")
            {
                try
                {
                    if (command[0] == "Reverse")
                    {
                        list.Reverse();
                    }
                    else if (command[0] == "Distinct")
                    {
                        list = list.Distinct().ToList();
                    }
                    else if (command[0] == "Replace")
                    {
                        int index = int.Parse(command[1]);
                        string word = command[2];
                        if (index < 0 || index > list.Count - 1)
                        {
                            throw new ArgumentException("Invalid input!");
                        }
                        else
                        {
                            list[index] = word;
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message); ;
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
