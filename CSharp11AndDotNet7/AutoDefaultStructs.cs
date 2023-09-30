using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11AndDotNet7
{
    internal class AutoDefaultStructs
    {

    }

    struct Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point2D()
        {
            Y = 2;
            //X = 3; x value will be assigend as default value of the type
        }
    }
}
