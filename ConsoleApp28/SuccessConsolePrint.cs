using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28
{
    class SuccessConsolePrint : ISuccessPrint
    {
        public void Print(string result)
        {
            Console.WriteLine(result);
        }
    }
}
