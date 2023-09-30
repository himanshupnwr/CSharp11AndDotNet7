using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11AndDotNet7
{
    //Main goal of file access modifier is for source generators to avoid source generated files that 
    //are in the same namespace to conflict with names
    //file keyword make the type available only in that file and not visible outside it
    public class FileAccessModifier
    {
        public void Methodcheck()
        {
            static Point3D GetPoint() => new() { Y = 0, X = 0, Z = 0 };
        }
    }

    file struct Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
}
