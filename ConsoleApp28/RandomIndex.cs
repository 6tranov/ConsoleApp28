using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28
{
    class RandomIndex
    {
        private System.Security.Cryptography.RNGCryptoServiceProvider RNG { get; }
        private byte[] RNO { get; }
        public RandomIndex()
        {
            this.RNG = new System.Security.Cryptography.RNGCryptoServiceProvider();
            this.RNO = new byte[5];
        }
        public int Index(int untilN)
        {
            RNG.GetBytes(RNO);
            return (int)(BitConverter.ToUInt32(RNO, 0) % (uint)(untilN + 1));
        }
    }

}
