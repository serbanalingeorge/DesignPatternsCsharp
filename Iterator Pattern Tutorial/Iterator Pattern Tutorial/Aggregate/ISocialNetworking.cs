using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator_Pattern_Tutorial.Iterator;

namespace Iterator_Pattern_Tutorial.Aggregate
{
    public interface ISocialNetworking
    {
        IIterator CreateIterator();
    }
}
