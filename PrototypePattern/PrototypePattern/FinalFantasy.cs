using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class FinalFantasy : XboxGame
    {
        public FinalFantasy(string text)
        {
            Title = text;
        }
        public override XboxGame Clone()
        {
            return (FinalFantasy)this.MemberwiseClone();
        }
    }
}
