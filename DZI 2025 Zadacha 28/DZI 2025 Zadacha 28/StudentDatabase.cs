using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZI_2025_Zadacha_28
{
    public class StudentDatabase
    {
        private List<Student> students;
        public string GetStudentInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Списъка на курса:");
            foreach (Student student in this.students)
            { 
                sb.AppendLine(student.ToString());  
            }
            return sb.ToString();
        }//end4
        public double GetStudentAverageScore(int Id)
        {
            var student = students.FirstOrDefault(x => x.StudentId == Id);
            if (student != null)
            {
               double average=student.Scores.Average();
                return average;
            }
            return 0;
        }//end5
        public void AddStudent(Student student)
        {
            students.Add(student);
        }//end1
        public void RemoveStudent(int Id)
        {
            var student=students.FirstOrDefault(x=>x.StudentId==Id);
            if (student != null)
            {
                students.Remove(student);
            }
            Console.WriteLine($"Студент с {Id} не съществува!");
        }//end2
        public StudentDatabase()
        {
            this.students = new List<Student>();
        }
    }
}
