using System.Runtime.CompilerServices;

namespace ZadachaDZI2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                list.Add(number);
            }
            Console.WriteLine(ReadPoints(list));
        }
        public static int ReadPoints(List<double> list)
        {
            return list.Where(x=>x>0).Count();
        }
        public static double МinDpoints(List<double> list)
        {
            double min = double.MaxValue;
            var tempList=list.Where(x=>x>0).ToList();
            var minPoint = min - tempList[0];
            for (int i = 1; i < tempList.Count; i++) 
            { 
             
            }
            
        }
    }
}
