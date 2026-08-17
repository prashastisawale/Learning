using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _28Demo_FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\ADMIN\source\repos\NetDemos\28Demo_FileIO\Data\data.txt";

            string filePath2 = @"C:\Users\ADMIN\source\repos\NetDemos\28Demo_FileIO\Data\empdata.txt";


            #region StreamWriter
            FileStream fs = null;
            if (File.Exists(filePath))
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);


            }
            else
            {
                fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);


            }
            StreamWriter writer = new StreamWriter(fs);

            writer.WriteLine("Welcome to fileIO");

            writer.WriteLine("abcd");

            writer.Flush();
            fs.Close();
            Console.WriteLine("Done");
            //    #endregion


            //    #region StreamReader
            //    //FileStream fs = null;

            //    //if(File.Exists(filePath))
            //    {
            //        fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);


            //    }
            //    else
            //    {
            //        Console.WriteLine("File does not exist");


            //    }
            //    StreamReader reader = new StreamReader(fs);
            //    //string data = reader.ReadToEnd();
            //    //reader.Close();
            //    //fs.Close();

            //    //Console.WriteLine(data);
            //    #endregion

            //    #region StreamWriter for Emp object
            //    //FileStream fs = null;
            //    //if (File.Exists(filePath))
            //    //{

            //    //}

            #endregion

            //}
        }
    }
    public class Emp
    {
        private int _EID;
        private string EName;
        private string _EAddress;

        public string Address
        {
            get { return _EAddress; }
            set { _EAddress = value; }
        }

        public string Name
        {
            get { return EName; }
            set { EName = value; }
        }

        public int Id
        {
            get { return _EID; }
            set { _EID = value; }
        }

        public void GetEmpDetails()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Address: {Address}");
        }
    }
}
