using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class MeatLoverPizza : Pizza
    {
        public override void AddToppings()
        {
            Console.WriteLine("Adding bacon, chicken, beef...");
        }
    }
}
