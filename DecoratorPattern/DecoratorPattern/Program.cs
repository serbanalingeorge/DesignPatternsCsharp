using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IceCream iceCream = new Chocolate();

            iceCream = new Sprinkle(iceCream);
            iceCream = new Fudge(iceCream);
            iceCream = new Blueberries(iceCream);

            Console.WriteLine(iceCream.Cost());

            Console.ReadLine();
        }
    }
}
