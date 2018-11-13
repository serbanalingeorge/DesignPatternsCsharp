using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator_Pattern_Tutorial.Iterator;

namespace Iterator_Pattern_Tutorial.Aggregate
{
    public class Twitter : ISocialNetworking
    {
        private string[] Users;

        public Twitter()
        {
            Users = new[] {"Kathy", "Lori", "Kristen", "Jamie"};
        }

        public IIterator CreateIterator()
        {
            return new TwitterIterator(Users);
        }
    }
}
