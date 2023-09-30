using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11AndDotNet7
{
    internal class ListPatterns
    {
        //list pattern matching
        public void patterns()
        {
            var ints = new[] { 3, 4, 5, 6, 7 };
            var ints2 = new int[] { 1, 4, 5, 6, 7 };
            var ints3 = new[] { 1 };
            var ints4 = new int[] { 1,2,3,4,5,5,6,7,7,8 };

            if(ints is [var first, .. var rest])
            {
                Console.WriteLine("Array is not empty");
                Console.WriteLine("First Element is " + first);

                if(rest is not null)
                {
                    Console.WriteLine($"Other elements + {rest.ToString()}");
                }
            }
            if(ints is [var firstint, ..var middle, var last])
            {
                Console.WriteLine("first element" + firstint);
            }
            if(ints is [1 or 3, .., <5])
            {
                Console.WriteLine("Array is not empty");
            }

            var emptyName = Array.Empty<string>();
            var myName = new[] { "FirstName LastName" };
            var nameBrokenDown = new[] { "FirstName", "LastName" };

            var text = myName switch
            {
                [] => "Name was empty",
                [var fullname] => $"My Full name is: {fullname}",
                [var firstName, var lastName] => $"My Full name is: {firstName} {lastName}"
            };
        }
    }
}
