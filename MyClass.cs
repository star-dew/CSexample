using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public static void StaticMethod()
        {
            Console.WriteLine("StaticMethod 수행");
        }

        public void InstanceMethod()
        {
            Console.WriteLine("InstanceMethod 수행");
        }
    }
}
