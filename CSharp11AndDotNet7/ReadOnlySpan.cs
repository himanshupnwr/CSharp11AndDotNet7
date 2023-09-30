using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11AndDotNet7
{
    //pattern matching span
    internal class ReadOnlySpanDemo
    {
        public ReadOnlySpanDemo() {
            ReadOnlySpan<char> chars = "Name String";

            if(chars is "Name String")
            {
                Console.WriteLine("Yes its same");
            }
        }
    }
}
