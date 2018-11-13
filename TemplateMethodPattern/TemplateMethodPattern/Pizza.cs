using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class Pizza
    {
        public void MakePizza()
        {
            MakeDough();
            AddTomatoeSauce();
            AddCheese();
            AddToppings();
        }
        public void AddCheese()
        {
            Console.WriteLine("Adding Cheese");
        }

        public void AddTomatoeSauce()
        {
            Console.WriteLine("Adding tomato");
        }

        public void MakeDough()
        {
            Console.WriteLine("Worked the dough");
        }

        public abstract void AddToppings();
    }
}
