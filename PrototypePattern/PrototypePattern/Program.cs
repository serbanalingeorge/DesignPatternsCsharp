using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            XboxGame xg = new Halo("Halo 4") {ProductKey = "00000-00000-00000-00000"};  //Original Copy of Halo
            XboxGame gameCopy;

            for (int x = 0; x < 10; x++)
            {
                Thread.Sleep(2000); //Not specific to this design pattern. 
                gameCopy = xg.Clone();
                gameCopy.ProductKey = XboxGame.ProductKeyGeneration();
                Console.WriteLine("Game Title: {0} Product Key: {1}",gameCopy.Title,gameCopy.ProductKey);
            }
            Console.Read();
        }
    }
}
