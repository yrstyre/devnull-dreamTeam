﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using devnull;
using models;
using Newtonsoft.Json;

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
            dnClient.Scan();

            var scanresult = dnClient.ScanResult;

            //dnClient.Pickup();

            Console.Read();
        }

    }

}

