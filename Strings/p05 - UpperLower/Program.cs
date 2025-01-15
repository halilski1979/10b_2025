namespace p05___UpperLower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Welcome to Velingrad!";
            Console.WriteLine(word);

            string word1=word.ToLower();
            Console.WriteLine(word1);

            string word2=word1.ToUpper();
            Console.WriteLine(word2);
        }
    }
}
