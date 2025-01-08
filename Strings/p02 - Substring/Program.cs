namespace p02___Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Welcome to Velingrad!";
            Console.WriteLine(word);

            string newWord = word.Substring(11);
            Console.WriteLine(newWord);

            string word1=word.Substring(7,3);
            Console.WriteLine(word1);

            string grad=word.Substring(word.IndexOf('g'),4);
            Console.WriteLine(grad);
        }
    }
}
