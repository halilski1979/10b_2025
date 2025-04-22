namespace P02___Demo___PoletaSvoistva___Metodi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Създаване на нов обект от тип Person (персона/ученик)
            Person p = new Person();
            p.Name = "Ivan";        
            p.Age = 17;             
            p.Klass = 10;           
            p.Uspeh = 5.34;        

            // Създаване на втори обект от тип Person
            Person q = new Person();
            q.Name = "Petar";      
            q.Age = 16;           
            q.Klass = 10;         
            q.Uspeh = 3.45;         

            // Извикване на метод от тип void – отпечатва информацията директно на конзолата
            p.Print();             
            q.Print();               
            Console.WriteLine();    

            // Извикване на метод, който връща string – резултатът се отпечатва с Console.WriteLine
            Console.WriteLine(p.Pechat());   
            Console.WriteLine(q.Pechat());   
            Console.WriteLine();

            // Използване на метода ToString() – извиква се автоматично при отпечатване на обект. 
            Console.WriteLine(p);    
            Console.WriteLine(q);     
        }
    }
}
