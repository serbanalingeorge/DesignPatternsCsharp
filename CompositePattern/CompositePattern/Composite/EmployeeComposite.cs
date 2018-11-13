using System;
using System.Collections;
using System.Collections.Generic;

namespace CompositePattern
{
    class EmployeeComposite : EmployeeComponent
    {
        private IList<EmployeeComponent> emplyees;

        public EmployeeComposite(string name) : base(name)
        {
            emplyees = new List<EmployeeComponent>();
        }

        public void AddEmployee(EmployeeComponent e)
        {
            emplyees.Add(e);
        }

        public void RemoveEmployee(EmployeeComponent e)
        {
            emplyees.Remove(e);
        }

        public override void PrintSupervisorOf(int spacing)
        {
            base.PrintSupervisorOf(spacing);
            foreach (EmployeeComponent e in emplyees)
            {
                e.PrintSupervisorOf(spacing + 1);
            }
        }
    }
}