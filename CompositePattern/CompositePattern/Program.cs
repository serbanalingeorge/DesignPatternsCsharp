using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeComposite mark = new EmployeeComposite("Mark");
            Employee catherine = new Employee("Catherine");
            Employee david = new Employee("David");

            EmployeeComposite kathy = new EmployeeComposite("Kathy");
            EmployeeComposite mike = new EmployeeComposite("Mike");
            Employee gage = new Employee("Gage");
            Employee reg = new Employee("Reggie");

            //Lori is the boss of Mark and Kathy
            EmployeeComposite lori = new EmployeeComposite("Lori");
            lori.AddEmployee(mark);
            lori.AddEmployee(kathy);

            //Mark is the boss of Catherine, David
            mark.AddEmployee(catherine);
            mark.AddEmployee(david);

            //Kathy is the boss of Mike
            kathy.AddEmployee(mike);

            //Mike is the boss of Gage and Reg
            mike.AddEmployee(gage);
            mike.AddEmployee(reg);

            //Print, by calling the very top
            lori.PrintSupervisorOf(0);
            kathy.PrintSupervisorOf(0);
            mark.PrintSupervisorOf(0);
            Console.Read();
        }
    }
}
