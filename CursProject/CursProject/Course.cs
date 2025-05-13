using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursProject
{
    public class Course
    {
		private string name;
		private int capacity;
		public void AddStudent(string studentName)
		{
			Student student = new Student(studentName);
			if (students.Contains(student)||students.Count>Capacity)
			{
				throw new ArgumentException($"Course containt {studentName}");
			}
			students.Add(student);
		}//end1
        public Course(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
			students = new List<Student>();
        }
        private List<Student> students { get; set; }
        public int Capacity
		{
			get { return capacity; }
			set 
			{
				if (value == 0)
				{
					throw new ArgumentException();
				}
				
				capacity = value; 
			}
		}
		public string Name

		{
			get { return name; }
			set
			{ 
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException("Name can not empty string");	
				} 
				name = value; 
			}

		}
        public override string ToString()
        {
			StringBuilder sb = new StringBuilder();
			foreach (Student student in students) 
			{ 
			  sb.AppendLine($"Студент: {student.Name} е записан в курса: {Name}");
			}
			return sb.ToString();
        }

    }
}
