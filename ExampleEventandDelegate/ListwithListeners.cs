using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleEventandDelegate
{
    public delegate void ChangedEventHandler();

    public class ListwithListeners:List<int>
    {

        public ChangedEventHandler Changed;

        public void add(int t)
        {
            base.Add(t);
            Changed();                        
        }

        public void print()
        {
            Console.WriteLine("self");
        }
    }
}
