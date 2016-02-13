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

            dnClient.Do();
        }
    }
}
