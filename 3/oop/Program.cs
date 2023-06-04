using System.Reflection.Metadata;

namespace OOP_O1
{
    internal class Program
    {   //<CLASS modifier > class  <Class Name>
        public class Employee
        {
            public static double TAX = 0.03; 

            public string firstName;
            public string lastName;
            public double  wage;
            public double  loggedHours ;

            //Method Syntax (simple)
            //public
            //<Access Modifier > <Datatype> / Void  Method Name (Parameters)
            /*
                {
                    series of Statments
            }             
             
             */
            public void DoSomething()
            {
                Console.WriteLine($" HELLO employee ");
            }
            public int Dothing()
            {
                int x = 100;
                return x * x;
            }

        }
        static void Main(string[] args)
        {   Employee emp = new Employee();

            Employee[] emps = new Employee[3]; 
            
            Console.WriteLine("please ener you first name :  ");
            emp.firstName = Console.ReadLine();

            Console.WriteLine("please ener you first name :  ");
            emp.lastName= Console.ReadLine();
            
            Console.WriteLine("please ener you first name :  ");
            emp.wage = double.Parse(Console.ReadLine()) ;

            Console.WriteLine("please ener you first name :  ");
            emp.loggedHours = double.Parse(Console.ReadLine());

            double netsalary = (emp.wage * emp.wage) - (emp.wage * emp.loggedHours * Employee.TAX) ;

            Console.WriteLine($"first name : {emp.firstName}");
            Console.WriteLine($"last name : {emp.lastName}");
            Console.WriteLine($"wage : {emp.wage}");
            Console.WriteLine($"logged hours : {emp.loggedHours}");
            Console.WriteLine($"Net salary : {netsalary}");
        }
    }
}