using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var sg = new StringGenerater("はたらくさいぼう");
                if (sg.CanGenerate(20000000))
                {
                    Console.WriteLine(sg.Result);
                }
                else
                {
                    Console.WriteLine("終わりませんでした。");
                }
            }
        }
    }

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
    class StringGenerater
    {
        private string Target { get; }
        private RandomIndex R { get; }
        public string Result { get; private set; }
        public StringGenerater(string target)
        {
            Target = target;
            R = new RandomIndex();
            Result = "";
        }
        public bool CanGenerate(int count)
        {
            Result = "";
            var charArray = Target.ToCharArray();
            for (int i = 0; i < count; i++)
            {
                if (i % 10000 == 0) Console.WriteLine(i);
                Result += charArray[R.Index(Target.Length - 1)];
                if (Result.EndsWith(Target)) return true;
            }
            return false;
        }
    }
}
