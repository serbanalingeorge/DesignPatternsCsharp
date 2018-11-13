﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Halo : XboxGame
    {
        public Halo(string title)
        {
            Title = title;
        }
        public override XboxGame Clone()
        {
            return (Halo) this.MemberwiseClone();
        }
    }
}
