using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharp11AndDotNet7
{
    internal class NewStringAttribute
    {
        //using string syntax attribute to help the developer understand which string is expected
        public void Method([StringSyntax(StringSyntaxAttribute.Json)] string regexPattern)
        {
            var math = Regex.Match("toto", regexPattern);

            Regex.Match("", "[a-z]{1}");
        }
    }

    internal class ProgramDemo
    {
        public ProgramDemo()
        {
            var vx = new NewStringAttribute();
            vx.Method("""
            {
                "type" : "Information"
            }
            """);
        }
    }
}
