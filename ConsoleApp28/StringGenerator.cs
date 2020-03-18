using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28
{
    class StringGenerator
    {
        private string Target { get; }
        private RandomIndex R { get; }
        public string Result { get; private set; }
        private int Count { get; set; }
        public StringGenerator(string target, int count)
        {
            Target = target;
            R = new RandomIndex();
            Result = "";
            Count = count;
        }
        public bool CanGenerate()
        {
            var sb = new StringBuilder();
            var charArray = Target.ToCharArray();
            var queue = new Queue<char>();
            var length = Target.Length;
            for (int i = 0; i < Count; i++)
            {
                char c = charArray[R.Index(Target.Length - 1)];
                sb.Append(c);
                queue.Enqueue(c);

                if (queue.Count > length)
                {
                    queue.Dequeue();
                }
                if (string.Join("", queue.ToArray()) == Target)
                {
                    Result = sb.ToString();
                    return true;
                }
            }
            Result = sb.ToString();
            return false;
        }
    }
}
