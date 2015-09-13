using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewOverrideExample
{
    public class BaseClass
    {
        public void method1()
        {
            Console.WriteLine("Base Method 1");
        }
        public void method2()
        {
            Console.WriteLine("Base Method 2");
        }
        public virtual void method3()
        {
            Console.WriteLine("Base Method 3");
        }
        public virtual void method4()
        {
            Console.WriteLine("Base Method 4");
        }
        public virtual void method5()
        {
            Console.WriteLine("Base Method 5");
        }
    }
}
