using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11AndDotNet7
{
    [AttributeUsage(AttributeTargets.Method)]
    public class MyAttribute : Attribute
    {
        public MyAttribute(string paramName) { 
            paramName = paramName.ToLower();
        }

        public string paramName;
    }

    internal class ExtendingNameOfScope
    {
        [My(nameof(paramName))]
        public void Methodtest(string paramName)
        {

        }
    }
}
