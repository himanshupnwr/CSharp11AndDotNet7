using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11AndDotNet7
{
    public interface MyInterface
    {
        static string Default = "Default";

        static abstract string Name { get; }
        static abstract void GetFullName();
    }

    internal class StaticAbstractMethods : MyInterface
    {
        public static string Name => throw new NotImplementedException();

        public static void GetFullName()
        {
            throw new NotImplementedException();
        }
    }

    class MyClass2
    {
        public void Method<T>() where T: MyInterface
        {

        }
    }

    class ProgramTest
    {
        public void testmenthods()
        {
            var c = new MyClass2();
            c.Method<StaticAbstractMethods>();
        }
    }
}
