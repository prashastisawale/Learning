namespace _3Demo_CSharpFeatures
{
    public delegate bool MyDelegate(int x);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Partial Class
            //CMath cmath = new CMath();
            //cmath.Add(2, 3);
            //cmath.Sub(14, 5); 
            #endregion

          
            Nullable<int> x = null;
            Nullable<double> salary = null;
            double? sal = null;
            string? str = Console.ReadLine();

            if (salary.HasValue)
            {
                Console.WriteLine($"Salary = {salary.Value}");
            }
            else
            {
                Console.WriteLine("Salary yet to be intialized.. still null value");
            }

            #region object Intializer
            Person p1 = new Person();
            Person p2 = new Person(12, "Peter");
            Person p3 = new Person("Ron", "Pune", 20);







        }

        public class Person
        {
            private int _Id;
            private string? _PName;
            private int _PAge;
            private string? _City;
            private string v1;
            private string v2;
            private int v3;
            private int v;

            public Person()
            {
            }

            public Person(int v, string v2)
            {
                this.v = v;
                this.v2 = v2;
            }

            public Person(string v1, string v2, int v3)
            {
                this.v1 = v1;
                this.v2 = v2;
                this.v3 = v3;
            }

            public string? City
            {
                
                get { return _City; }
                set { _City = value; }
            }

            public int PAge
            {
                get { return _PAge; }
                set { _PAge = value; }


            }
            public string? PName
            {
                get { return _PName; }
                set { _PName = value; }
            }

            public int Id
            {
                get { return _Id; }
                set { _Id = value; }
            }
        }
        public partial class CMath
        {
            private int? _Number;

            public int? Number
            {
                get { return _Number; }
                set { _Number = value; }
            }

            public void Add(int x, int y)
            {
                Console.WriteLine($"Add = {x+y}");
            }

            public void Sub(int x, int y)
            {
                Console.WriteLine($"Add = {x + y}");
            }



        }
    }
}

