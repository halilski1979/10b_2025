using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursProject
{
    public class Student
    {
        public string Name { get; set; }
       
        public Student(string name)
        {
            this.Name = name;
        }//end 2
        public void Enroll(Course course)
        {
            course.AddStudent(Name);
        }//end1
    }
}
