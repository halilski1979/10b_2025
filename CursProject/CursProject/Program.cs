namespace CursProject
{
    public class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.Write("Въведете име на курса: ");
                string name = Console.ReadLine();
                Console.Write("Въведете капацитет: ");
                int capacity = int.Parse(Console.ReadLine());
                Course course = new Course(name, capacity);
                Console.Write("Въведете брой студенти: ");
                int numbers = int.Parse(Console.ReadLine());
                for (int i = 0; i < numbers; i++)
                {
                    Console.Write("Въведете име на студент: ");
                    string nameStud = Console.ReadLine();
                    Student student = new Student(nameStud);
                    student.Enroll(course);
                }
                Console.WriteLine(new string('*', 10));
                Console.WriteLine(course.ToString());
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
