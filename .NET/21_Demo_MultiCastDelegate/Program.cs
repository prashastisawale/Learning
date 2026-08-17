using System.Security.Cryptography.X509Certificates;

namespace _21_Demo_MultiCastDelegate
{
    public delegate void MyEventHandler();
    internal class Program
    {
        static void Main(string[] args)
        {
            // Multi-cast Delegate Syntax

            Console.WriteLine("is shahrukh khan our special guest");
            bool isHere = false;


            AnnualFunction obj = new AnnualFunction();

            MyEventHandler handler = new MyEventHandler(obj.Welcome);
            handler += new MyEventHandler(obj.HostSpeech);
            handler += obj.GuestSpeech;


            // Conditional coupling / de coupling 
            if (isHere)
                handler += obj.specialGuestSpeech;
            else
                handler -= obj.specialGuestSpeech;

            handler += obj.Dance;
            handler += obj.DinnerParty;
            handler += obj.GoodBye;
            handler += obj.Packup;

            //series of handlers invoke -- methods invoke
            handler();
        }
    }



        public class AnnualFunction
        {
            public void Welcome()
            {
                Console.WriteLine("Welcome to our function");

            }

            public void HostSpeech()
            {
                Console.WriteLine("Host: blah blah");
            }
            public void GuestSpeech()
            {
                Console.WriteLine("Guest: blah blah");
            }
            public void  specialGuestSpeech()
            {
                Console.WriteLine("SpecialGuest: blah blah blah");
            }

            public void Dance()
            {
                Console.WriteLine("Grooving");
            }
            public void DinnerParty()
            {
                Console.WriteLine("Enjoy Your Food!");


            }
            public void GoodBye()
            {
                Console.WriteLine("Host: Event is over!!");
            }
            public void Packup()
            {
                Console.WriteLine("Packup....");
            }

          
        }
    }
    

