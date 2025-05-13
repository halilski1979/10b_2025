using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZI_2025_Zadacha_28
{
    public class Student
    {
        public Student(int studentId, string name, List<double> scores)
        {
            this.StudentId = studentId;
            this.Name = name;
            this.Scores = scores;
        }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<double> Scores { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{StudentId}, {Name}");
            sb.Append("Оценки: ");
            foreach (var item in Scores) 
            { 
                sb.Append(item+" ");
            }
            return sb.ToString();
        }
    }
}
