using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleEventandDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            ListwithListeners list = new ListwithListeners();
            Listener listen = new Listener(list);
            list.add(1);

            Console.Read();
        }
    }
}
