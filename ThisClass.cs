﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class ThisClass
    {
        int a, b, c;

        public ThisClass()
        {
            this.a = 5425;
            Console.WriteLine("ThisClass()");
        }

        public ThisClass(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"ThisClass({b})");
        }

        public ThisClass(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"ThisClass({b}, {c})");
        }

        public void PringFields()
        {
            Console.WriteLine($"a: {a} b: {b} c: {c}");
            Console.WriteLine();
        }
    }
}
