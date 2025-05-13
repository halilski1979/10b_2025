using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsResult
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<double> Scores { get; set; }
        public Student(int studentId,string name) 
        { 
            StudentId = studentId;
            Name = name;
            this.Scores = new List<double> {3,4,5,6,5,3 };
        }
    }
}
