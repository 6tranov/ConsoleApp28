using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var sg = new StringGenerator(new MatchDiscriminator("はいく"), 50000000);
                ISuccessPrint isp = new SuccessConsoleSimplePrint(10, 10);
                IFailurePrint ifp = new FailureConsolePrint("終わりませんでした。");

                var smp = new StringMatchPlay(sg, isp, ifp);
                for (int i = 0; i < 20; i++)
                {
                    smp.Do();
                }
            }
        }
    }


}
