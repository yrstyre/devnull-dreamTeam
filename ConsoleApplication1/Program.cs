using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using devnull;

namespace ConsoleApplication1
{
    public class Program
    {

        static void Main(string[] args)
        {
            var dnClient = new WebClient();

            for (int i = 0; i < 2; i++)
            {
                //dnClient.Walk("down");
            }
            var result = dnClient.Scan();
            //dnClient.Pickup();

            Console.Read();
        }
    }
}
