using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    abstract class EmployeeComponent
    {
        public string Name { get; private set; }

        public EmployeeComponent(string name)
        {
            this.Name = name;
        }
        public virtual void PrintSupervisorOf(int spacing)
        {
            for (int counter = 0; counter < spacing; counter++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(Name);
        }
    }
}
