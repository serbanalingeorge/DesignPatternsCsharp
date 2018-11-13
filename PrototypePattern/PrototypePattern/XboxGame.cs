using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class XboxGame
    {
        public string Title { get; set; }
        public string ProductKey { get; set; }

        public abstract XboxGame Clone();

        //Returns a product key (E.G ABCDE-QWERQ-ASDTR-ASQWE)
        public static string ProductKeyGeneration()
        {
            Random r = new Random();
            string productKey = "";

            for (int x = 0; x < 20; x++)
            {
                if (x % 5 == 0 && x!=0)
                {
                    productKey += "-";
                }
                productKey += (char) (r.Next(26) + 65);
            }
            return productKey;
        }
    }
}
