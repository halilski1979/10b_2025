namespace StudentsResult
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentDatabase studBase=new StudentDatabase();
            Console.Write("Брой студенти:");
            int n=int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                Console.Write("Id студент: ");
                int id=int.Parse(Console.ReadLine());
                Console.Write("Име на студент: ");
                string name=Console.ReadLine();
                Student st=new Student(id, name);
                studBase.AddStudent(st);
            }
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine(studBase.GetStudentInfo(i));
            }
        }
    }
}
