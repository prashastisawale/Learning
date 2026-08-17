namespace _12_demo_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.WrapperMethod();

            HR hr = new HR();
            hr.WrapperMethod();
            hr.Display();
        }
    }

    public class Person
    {
        public virtual string Name { get; set; }

        public virtual void Display()
        {
            Console.WriteLine("Person: Display");
        }
    }

    public class Employee : Person
    {
        public sealed override string Name
        {
            get => base.Name;
            set => base.Name = value;
        }
    }

    public class HR : Employee
    {
        public void EmpData()
        {
            Console.WriteLine("HR Employee Data");
        }

        public override void Display()
        {
            Console.WriteLine("HR: Display");
        }

        public void WrapperMethod()
        {
            Console.WriteLine("Wrapper Method of HR");
        }
    }

    public class Demo
    {
        public void WrapperMethod()
        {
            HR obj = new HR();
            obj.EmpData();
        }
    }
}
