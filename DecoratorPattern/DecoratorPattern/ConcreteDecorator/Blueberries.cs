using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    public class Blueberries : Topping
    {
        public Blueberries(IceCream s) : base(s)
        {
        }

        public override double Cost()
        {
            return 0.50 + IceCream.Cost();
        }
    }
}
