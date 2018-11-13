using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator_Pattern_Tutorial.Iterator;

namespace Iterator_Pattern_Tutorial.Aggregate
{
    public class Facebook : ISocialNetworking
    {
        private LinkedList<string> Users;

        public Facebook()
        {
            //Sign up for a facebook account
            Users = new LinkedList<string>();
            Users.AddLast("Mike");
            Users.AddLast("Jason");
            Users.AddLast("Asad");
            Users.AddLast("Sen");
            Users.AddLast("Vish");
            Users.AddLast("Senthu");
        }

        public IIterator CreateIterator()
        {
            return new FacebookIterator(Users);
        }
    }
}
