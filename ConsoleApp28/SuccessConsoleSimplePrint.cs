using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28
{
    class SuccessConsoleSimplePrint : ISuccessPrint
    {
        private int HeadStringLength { get; }
        private int FootStringLength { get; }
        public SuccessConsoleSimplePrint(int headStringLength, int footStringLength)
        {
            HeadStringLength = headStringLength;
            FootStringLength = footStringLength;
        }
        public void Print(string result)
        {
            if (result.Length < HeadStringLength + FootStringLength + 2)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine($"{result.Substring(0, HeadStringLength)}…{result.Substring(result.Length - FootStringLength)}({result.Length}文字)");
            }
        }
    }
}
