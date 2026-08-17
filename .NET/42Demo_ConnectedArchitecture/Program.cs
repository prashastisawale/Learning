using _42Demo_ConnectedArchitecture.DAL;
using _42Demo_ConnectedArchitecture.Models;

namespace _42Demo_ConnectedArchitecture
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter your Db OPeartion CHoice: 1. Select, 2. Select by Id, 3. Insert, 4. Update, 5.Delete");
                int opchoice = Convert.ToInt32(Console.ReadLine());

                IETDBContext dbContext = new IETDBContext();
                int rowsAffected = 0;

                switch (opchoice)
                {
                    case 1:
                        List<Emp> emps = dbContext.SelectRecords();
                        foreach (var Emp in emps)
                        {
                            Emp.GetEmpData();
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter emp Id to be searched:");
                        int idToBeSearched = Convert.ToInt32(Console.ReadLine());

                        Emp emp = dbContext.SelectEmpById(idToBeSearched);

                        if(emp != null)
                        {
                            emp.GetEmpData();
                        }
                break;

                    case 3:
                        Emp empToBeInserted = new Emp();
                        Console.WriteLine("Enter Emp Id :");
                        empToBeInserted.Id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Emp Name:");
                            empToBeInserted.Name = Console.ReadLine();


                        Console.WriteLine("Enter Emp Address:");
                        empToBeInserted.Address = Console.ReadLine();

                        rowsAffected = dbContext.InsertRecord(empToBeInserted);
                        if(rowsAffected > 0)
                        {
                            Console.WriteLine("Record inserted in database successfully");
                        }

                        break;

                    case 4:
                        Emp empToBeUpdated = new Emp();

                        Console.WriteLine("Enter Emp Id: to be updated: ");
                        empToBeUpdated.Id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Name of Emp to be Updated: ");
                        empToBeUpdated.Name = Console.ReadLine();

                        Console.WriteLine("Enter Address of Emp to be Updated: ");
                        empToBeUpdated.Address = Console.ReadLine();

                        rowsAffected = dbContext.UpdateRecord(empToBeUpdated.Id, empToBeUpdated);
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Record updated in database successfully!!");
                        }

                        break;
                    case 5:
                        Console.WriteLine("Enter Emp Id To be Deleted: ");
                        int empIdToBeDeleted = Convert.ToInt32(Console.ReadLine());

                        rowsAffected = dbContext.DeleteRecord(empIdToBeDeleted);
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Record deleted from database successfully!!");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Db Operation Choice!!!");
                        break;

                }

                Console.WriteLine("Do you want to continue?: y/n");
                string ynChoice = Console.ReadLine().ToLower();
                if (ynChoice == "n")
                    break;
            }
        }
    }
}