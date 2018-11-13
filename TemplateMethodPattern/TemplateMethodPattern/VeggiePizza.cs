using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class VeggiePizza : Pizza
    {
        public override void AddToppings()
        {
            Console.WriteLine("Adding mushrooms, peppers, onions ...");
        }
    }
}
