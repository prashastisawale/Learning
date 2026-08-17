namespace _03Demo_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DataTypes
            #region Printing Datatypes types using GetType Method
            System.Int 32 x = 10
           int x = 10;
            int32 x = 10;
            Type x_type = x.GetType();
            Console.WriteLine(x + " " + x_type.ToString());

            int y = 20;
            Console.WriteLine(y +" "+ y_type.ToString());

            string str = "Huge Jackman";
            Console.WriteLine(String + " " + str.GetType().ToString());

            short num = 10;
            Console.WriteLine(num + " " + num.GetType().ToString());

            long num2 = 1234789;
            Console.WriteLine(num2 + " " + num2.GetType().ToString());

            double d = 22.23;
            Console.WriteLine(d + " " + d.GetType().ToString());

            #endregion

            #region Input from user, Convert.To()methods
//Console.WriteLine("Enter a Number:"
//string ip = Console.ReadLine();








        }
    }
}
