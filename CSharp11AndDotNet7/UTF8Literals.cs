using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11AndDotNet7
{
    internal class UTF8Literals
    {
        public UTF8Literals() { }

        public void Example()
        {
            ReadOnlySpan<byte> bytes = "stringforutf8"u8; //this is a utd byte array
        }
    }
}
