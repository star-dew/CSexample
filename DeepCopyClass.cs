﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example
{
    class DeepCopyClass
    {
        // 필드
        public int MyField1;
        public int MyField2;

        public DeepCopyClass DeepCopy()
        {
            DeepCopyClass newCopy = new DeepCopyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }
}
