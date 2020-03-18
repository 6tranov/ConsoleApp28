using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28
{
    class FailureConsolePrint : IFailurePrint
    {
        private string Msg { get; }
        public FailureConsolePrint(string msg)
        {
            this.Msg = msg;
        }
        public void Print()
        {
            Console.WriteLine(Msg);
        }
    }
}
