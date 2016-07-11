using System;
using System.Collections.Generic;

namespace Structs
{
    //Used like classes.The difference is:
    //the memory is copied by value rather than copied by reference. 
    //no internal, internal protected, or static modifiers
    //no inheritance/derivation
    public struct Example
    {
        public int sum(int a, int b)
        {
            return (a + b);
        }

    static void Main()
        {
            Example e = new Example();
            Console.WriteLine(e.sum(3,4));

        }
    }
        

}