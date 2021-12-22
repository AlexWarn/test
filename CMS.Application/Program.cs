

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SharpPad;

namespace CMS.Application
{
    class Program
    {
        static List<Item> items = new List<Item>();

        static async Task Main(string[] args)
        {
            init();
            int f = 344;
            await items.Dump();
        }

        private static void init()
        {
            items.Add(new Item("Name11", 21));
            items.Add(new Item("Name2", 22 ));
            items.Add(new Item("Name3", 23));
        }


    }
}