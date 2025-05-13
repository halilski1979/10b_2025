using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsResult
{
    public class StudentDatabase
    {
        private List<Student> students=new List<Student>();
        public void AddStudent(Student student)
        {
            students.Add(student);
        }//end1
        public void RemoveStudent(int id)
        {
            students.RemoveAt(id);
        }//end2
        public string GetStudentInfo(int id)
        {
            var searchStudent=students.FirstOrDefault(x=>x.StudentId==id);
            if (searchStudent != null)
            {
                return $"{searchStudent.Name}: Оценки: {string.Join(", ",searchStudent.Scores)}";
            }
            return $"Студент с {id} не съществува!";
        }//end3
        public double AverageScores(int id)
        {
            var searchStudent=students.FirstOrDefault(y=>y.StudentId==id);
            if (searchStudent != null) 
            { 
            return searchStudent.Scores.Average(x=>x);
            }
            return 0.0;
        }
    }
}
