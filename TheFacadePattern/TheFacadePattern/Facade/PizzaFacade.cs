using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFacadePattern.Concrete;

namespace TheFacadePattern.Facade
{
    public class PizzaFacade
    {
        private Dough dough;
        private Sauce sauce;
        private Topping top;
        private Cheese cheese;
        private Oven oven;
        public PizzaFacade(Dough dough, Sauce sauce, Topping top, Cheese cheese)
        {
            this.dough = dough;
            this.sauce = sauce;
            this.top = top;
            this.cheese = cheese;
        }
        public void MakePizza()
        {
            dough.AddSauce(sauce);
            dough.AddCheese(cheese);
            dough.AddTopping(top);
            oven.SetTemperature(425);
            oven.SetTimer(20);
            oven.Cook(dough);
        }
    }
}
