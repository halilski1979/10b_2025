using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02___Demo___PoletaSvoistva___Metodi
{
    public class Person
    {
        // Полета на класа – съдържат информацията за обект от този клас
        private string name;     // Име на ученика
        private int age;         // Възраст на ученика
        private int klass;       // Клас, в който е ученикът
        private double uspeh;    // Успехът (средна оценка) на ученика

        
        
        // Свойство за достъп до полето name (име)
        public string Name
        {
            get { return name; }         // Взема текущото име
            set { name = value; }        // Задава ново име
        }

        // Свойство за достъп до полето age (възраст)
        public int Age
        {
            get { return age; }          
            set { age = value; }        
        }

        // Свойство за достъп до полето klass (клас)
        public int Klass
        {
            get { return klass; }        
            set { klass = value; }       
        }

        // Свойство за достъп до полето uspeh (успех)
        public double Uspeh
        {
            get { return uspeh; }        
            set { uspeh = value; }      
        }

       
        
        
        // Метод, който отпечатва информация за ученика на конзолата
        public void Print()
        {
           
            Console.WriteLine($"Az se kazvam {this.Name}. V {this.Klass} klas, na {this.Age} godini. Moqt uspeh e {this.Uspeh}!");
        }

        // Метод, който връща текстов низ с информация за ученика
        public string Pechat()
        {
            
            return $"Uchenikat {this.Name} e v {this.Klass}, na {this.Age} godini. Ima uspeh {this.Uspeh}";
        }

        // Метод, който замества стандартния ToString() – използва се когато обектът се превръща в текст
        public override string ToString()
        {
            // Връща съобщение на английски език
            return $"My name is {this.Name}, {this.Age} years old. I am in {this.Klass} klas. My grade is {this.Uspeh}";
        }
    }
}
