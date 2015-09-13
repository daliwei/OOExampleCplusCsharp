using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewOverrideExample
{
    public class DerivedClass:BaseClass
    {
        public void method1()
        {
            Console.WriteLine("derived method 1");
        }

        public new void method2()
        {
            Console.WriteLine("derived method 2");
        }
        
        public void method3()
        {
            Console.WriteLine("derived method 3");
        }

        public new void method4()
        {
            Console.WriteLine("derived method 4");
        }

        public override void method5()
        {
            Console.WriteLine("derived method 5");
        }
    }
}
