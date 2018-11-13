using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullObjectPattern.Strategies;
using NullObjectPattern.Strategy_Pattern.Context;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon weapon = null;
            Character Player = new Character();

            while (true)
            {
                Console.WriteLine("Choose a weapon for Player! (1 = Sword, 2 = Axe, 3 = Club)");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        weapon = new Sword();
                        break;
                    case "2":
                        weapon = new Axe();
                        break;
                    case "3":
                        weapon = new Club();
                        break;
                    default:
                        weapon = new Null();
                        break;
                }
                Player.SetWeapon(weapon);
                Player.Attack();
            }
        }
    }
}
