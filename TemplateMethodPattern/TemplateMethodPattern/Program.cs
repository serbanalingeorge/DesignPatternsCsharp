using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new MeatLoverPizza();
            pizza1.MakePizza();


            Pizza pizza2 = new VeggiePizza();
            pizza2.MakePizza();

            Console.WriteLine();
            Console.Read();
        }
    }
}
