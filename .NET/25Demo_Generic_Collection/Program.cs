using System.Drawing;
namespace _25Demo_Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List<int>
            //List<int>numbers = new List<int>();
            //numbers.Add(10);
            //numbers.Add(200);
            //numbers.Add(3);
            //numbers.Add(40);
            // for (int i = 0; i < numbers.Count; i++)
            // {
         //   Console.WriteLine(numbers[i]);
       // }
            #endregion

        

                #region Stack<>
                //Stack<string> st = new Stack<string>();
                //st.Push("1");
                //st.Push("2");
                //st.Push("3");
                //int count = st.Count;
                //for (int i = 0; i< count; i++)
                //{ 
                //    Console.WriteLine(st.Pop());
                //}
                #endregion

                Emp emp1 = new Emp();
                emp1.Id = 1;
                emp1.Name = "Hugh Jackman";
                emp1.Address = "NYC";

                Emp emp2 = new Emp();
                emp2.Id = 2;
                emp2.Name = "Tom Holland";
                emp2.Address = "LA";

                Emp emp3 = new Emp();
                emp3.Id = 3;
                emp3.Name = "Tom Holland";
                emp3.Address = "New Jercy";


                #region List<Emp>
                List<Emp> allemps = new List<Emp>();
                allemps.Add(emp1);
                allemps.Add(emp2);
                allemps.Add(emp3);

                for (int i = 0; i< allemps.Count; i++)
                {
                    Emp emp = allemps[i];
                    Console.WriteLine($"Id:{allemps[i].Id}, Name: {allemps[i].Name}, Address: {allemps[i].Address}");

                }


            #endregion

            #region Dictionary<TKey, TValue>

            Dictionary<int, Emp> allEmps = new Dictionary<int, Emp>();

            allEmps.Add(1, emp1);
            allEmps.Add(2, emp2);
            allEmps.Add(3, emp3);

            foreach (Emp emp in allEmps.Values)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Address: {emp.Address}");
            }

            #endregion


        }
    }

        public class Emp
        {
            private int EId;
            private string _EName;
            private string _EAddress;
                public string Address
            {
                get { return _EAddress; }
                set { _EAddress = value; }
            }
            public string Name
            {
                get { return _EName; }
                set { _EName = value; }
            }

            public int  Id
            {
                get { return EId; }
                set {  EId = value; }
            }

        }
    }

