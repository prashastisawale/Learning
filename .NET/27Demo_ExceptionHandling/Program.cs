using System.Linq.Expressions;

namespace _27Demo_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 0;
            try
            {
                if (y == 0)
                {
                    //throw new DivideByZeroException("y can not be Zero");
                    throw new MyCustomException("Divisor can not zero");
                }
                int div = x / y;
                Console.WriteLine($"Div result = {div}");
            }
            //catch (IndexOutOfRangeException ex)
            { }
            // catch (ObjectDisposeException obj)

            //catch (FileNotFoundException ex){ }
            CatchBlock (DivideByZeroException ex)
                {
                Console.WriteLine(ex.Message);
            }
            CatchBlock (MyCustomException ex)
                {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Every time this code will get called..");
                //obj.Dispose();

            }

               
        }

    }

    public class MyCustomException: Exception
    {
        public MyCustomException(string message):base(message)
        { 
        
        }
    }
}