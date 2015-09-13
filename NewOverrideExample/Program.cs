using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewOverrideExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bs = new BaseClass();
            BaseClass bsds = new DerivedClass();
            DerivedClass ds = new DerivedClass();

            Console.WriteLine("without virtual or new or override");
            bs.method1();
            bsds.method1();
            ds.method1();


            Console.WriteLine("with only new");
            bs.method2();
            bsds.method2();
            ds.method2();


            Console.WriteLine("with only virtual");
            bs.method3();
            bsds.method3();
            ds.method3();


            Console.WriteLine("with virtual and new");
            bs.method4();
            bsds.method4();
            ds.method4();


            Console.WriteLine("with virtual and override");
            bs.method5();
            bsds.method5();
            ds.method5();

            Console.Read();
        }
    }
}
