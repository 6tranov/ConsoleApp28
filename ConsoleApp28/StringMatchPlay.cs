using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28
{
    class StringMatchPlay
    {
        private StringGenerator SG { get; }
        private ISuccessPrint ISP { get; }
        private IFailurePrint IFP { get; }
        public StringMatchPlay(StringGenerator sg, ISuccessPrint isp, IFailurePrint ifp)
        {
            SG = sg;
            ISP = isp;
            IFP = ifp;
        }
        public void Do()
        {
            if (SG.CanGenerate())
            {
                ISP.Print(SG.Result);
            }
            else
            {
                IFP.Print();
            }
        }
    }
}
