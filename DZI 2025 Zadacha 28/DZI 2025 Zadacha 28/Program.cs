namespace DZI_2025_Zadacha_28
{
    using System.IO;
    public class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllLines("students.txt");
            foreach (var line in text)
            { 
             var tempData=line.Split(' ').ToList();
             Console.WriteLine(tempData[0]);
            }
          
        }
    }
}
