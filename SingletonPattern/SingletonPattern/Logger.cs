using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Logger
    {
        private static Logger logger = null;

        private Logger(){}

        public static Logger GetInstance()
        {
            if (logger == null)
            {
                logger = new Logger();
            }
            return logger;
        }

        public void WriteToFile(string message)
        {
            Console.WriteLine(message);
        }
    }
}
