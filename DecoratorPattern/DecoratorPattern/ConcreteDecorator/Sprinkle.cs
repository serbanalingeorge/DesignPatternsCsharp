using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    public class Sprinkle : Topping
    {
        public override double Cost()
        {
            return 0.50 + IceCream.Cost();
        }

        public Sprinkle(IceCream s) : base(s)
        {
        }
    }
}
