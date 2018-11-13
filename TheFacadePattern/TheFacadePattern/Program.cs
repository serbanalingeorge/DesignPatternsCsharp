using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFacadePattern.Concrete;
using TheFacadePattern.Facade;

namespace TheFacadePattern
{
    class Program
    {
        //The client
        static void Main(string[] args)
        {
        }

        public void Client1()
        {
            Dough dough = new Dough();
            Sauce sauce = new Sauce("Tomato");
            Topping mushroom = new Topping("Mushrooms");
            Cheese mozzarella = new Cheese("Mozzarella");
            Oven oven = new Oven();
            PizzaFacade pf = new PizzaFacade(dough,sauce, mushroom,mozzarella);
            pf.MakePizza();
        }

        public void Client2()
        {
            Dough dough = new Dough();
            Sauce sauce = new Sauce("Tomato");
            Topping greenPep = new Topping("Green Peppers");
            Cheese mozzarella = new Cheese("Mozzarella");
            Oven oven = new Oven();
            PizzaFacade pf = new PizzaFacade(dough, sauce, mozzarella, greenPep);
            pf.MakePizza();
        }
    }
}
