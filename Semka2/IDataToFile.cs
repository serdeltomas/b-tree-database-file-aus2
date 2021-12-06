﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semka2
{
    public interface IDataToFIle<T>
    {
        public byte[] ToByteArray();
        public T FromByteArray(byte[] pArray);
        public int Size();
        public static byte[] AddBytes(byte[] pA, byte[] pB)
        {
            var z = new byte[pA.Length + pB.Length];
            pA.CopyTo(z, 0);
            pB.CopyTo(z, pA.Length);
            return z;
        }
    }
}
