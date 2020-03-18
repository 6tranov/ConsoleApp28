using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28
{
    class StringGenerator
    {
        public string Result => MD.Result();
        private int Count { get; set; }
        private MatchDiscriminator MD { get; }
        public StringGenerator(MatchDiscriminator md, int count)
        {
            this.MD = md;
            Count = count;
        }
        public bool CanGenerate()
        {
            for (int i = 0; i < Count; i++)
            {
                MD.Scan();
                if (MD.IsMatch())
                {
                    return true;
                }
            }
            return false;
        }
    }

    class MatchDiscriminator
    {
        private char[] CharArray { get; }
        private StringBuilder SB { get; }
        private Queue<char> Queue { get; }
        private int Length { get; }
        private RandomIndex R { get; }
        private string Target { get; }
        public MatchDiscriminator(string target)
        {
            Target = target;
            this.CharArray = Target.ToCharArray();
            this.SB = new StringBuilder();
            this.Queue = new Queue<char>();
            this.Length = Target.Length;
            this.R = new RandomIndex();
        }
        private int RandomIndex()
        {
            return R.Index(Length - 1);
        }
        private char C()
        {
            return CharArray[RandomIndex()];
        }
        public bool IsMatch()
        {
            return string.Join("", Queue.ToArray()) == Target;
        }
        public string Result()
        {
            return SB.ToString();
        }
        public void Scan()
        {
            char c = C();
            SB.Append(c);
            Queue.Enqueue(c);

            if (Queue.Count > Length)
            {
                Queue.Dequeue();
            }
        }
    }
}
