using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11AndDotNet7
{
    internal class Requiredkeyword
    {
        //cannot create an isntance of the class without specifying the value of this property
        public required string Name { get; set; }

    }
    public class Test
    {
        void TestMethod()
        {
            var p = new Requiredkeyword { Name = "Language" };
        }
    }
    
}
