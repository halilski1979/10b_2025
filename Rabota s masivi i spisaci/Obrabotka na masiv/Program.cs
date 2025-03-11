namespace Obrabotka_na_masiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements =Console.ReadLine().Split(' ').ToList();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                if (command[0]== "Distinct")
                {
                    elements=elements.Distinct().ToList();
                }
                else if (command[0]== "Reverse")
                {
                    elements.Reverse();
                }
                else if (command[0]=="Replace")
                {
                    int index = int.Parse(command[1]);
                    string word=command[2];
                    elements[index] = word;
                }
            }
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] != elements[elements.Count - 1])
                {
                    Console.Write(elements[i] + "," + " ");
                }
                else { Console.Write(elements[i]); }
            }
        }
    }
}
