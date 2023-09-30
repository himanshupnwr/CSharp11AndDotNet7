using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CSharp11AndDotNet7
{
    internal interface INumberInterface
    {
        public void Numbers()
        {
            var ints = new[] { 1, 2, 3 };
            var doubles = new[] { 1.5, 2.5, 3.5 };

            var result = Add(ints);
            var resultdouble = Add(doubles);
        }

        T Add<T>(T[] values) where T: INumber<T>
        {
            T result = T.Zero;
            foreach (var value in values)
            {
                result += value;
            }

            return result;
        }
    }
}
