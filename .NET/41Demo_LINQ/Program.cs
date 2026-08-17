using System.ComponentModel;
using System.Net.Sockets;

namespace _41Demo_LINQ
{
    internal class Program
    {
        static void Main(string[] args)

        {
            List<Emp> emps = new List<Emp>()
            {
                new Emp(){id = 1, Name = "John", Address = "Pune"},
                new Emp(){id = 2, Name = "BOb", Address = "Puri"},
                new Emp(){id = 3, Name = "Alice", Address = "Mumbai"},
                new Emp(){id = 4, Name = "Ria", Address = "Mp"},
                new Emp(){id = 5, Name = "Kem", Address = "Patna"},
                new Emp(){id = 6, Name = "Rey", Address = "Rajasthan"},

            };

            var result = from emp in emps select emp;

            foreach(var emp in result) 
            { 
                emp.DisplayEmpData();
            
            }

            Console.WriteLine("\n Employee Names:");

            var result1 = emps.Select(e => e.Name);

            foreach(var emp in result1) {
        }
    }

    public class Emp
    {
        public int id {  get; set; }
        public string? Name {  get; set; }

        public string? Address { get; set; }

        public void DisplayEmpData()
        {
            Console.WriteLine($"Id: {Id}, Name:{Name}, Address: {Address}");
        }
    }
}}