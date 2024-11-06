namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Масив
            int[] num = new int[5];
            int[] num1 = new int[] {11,12,13,14 };
            string[] dni = new string[] {"Po","Vt","Sr","Ch"};
            var imena = Console.ReadLine().Split(' ').ToArray();

            //Списък
            List<int> numbers=new List<int>();
            List<int> newNimber=new List<int>() {1,2,3,4};
            List<string> days=new List<string>() {"Po","Vt","Sr","Ch"};

            //Списък от 1 ред
            var names=Console.ReadLine().Split(' ').ToList();
            List<double> grade =Console.ReadLine().Split().Select(double.Parse).ToList();
            var newGrade = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        }
    }
}
