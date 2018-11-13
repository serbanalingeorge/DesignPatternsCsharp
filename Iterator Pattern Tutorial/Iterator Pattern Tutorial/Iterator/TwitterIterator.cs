﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern_Tutorial.Iterator
{
    public class TwitterIterator : IIterator
    {
        private string[] Users;
        private int position;

        public TwitterIterator(string[] users)
        {
            this.Users = users;
            position = 0;
        }
        public void First()
        {
            position = 0;
        }

        public string Next()
        {
            return Users[position++];
        }

        public bool IsDone()
        {
            return position >= Users.Length;
        }

        public string CurrentItem()
        {
            return Users[position];
        }
    }
}
