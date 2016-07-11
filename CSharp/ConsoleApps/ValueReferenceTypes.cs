using System;

namespace ValueReferenceTypes
{
    public class ValueTypes
    {
        //Value Types: struct, int, float, double, bool, char, decimal, byte
       
        public static int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        public static char c1 = 'X';        // Character literal
        public static char c2 = '\x0058';   // Hexadecimal
                      
        public static bool Sunny = true;
        
     }

    public class ReferenceTypes
    {
        //Reference Types: class, interface, delegate, string, dynamic, object

        public static string String = "String, class, and interface are reference types.";
        
     }

    public class Entry
    {
        public static void Main()
        {
            // Value Types
            //ValueTypes V = new ValueTypes(); this doesn't work
            Console.WriteLine(ValueTypes.getSum(3, 4));
            Console.WriteLine("Characters: {0} {1}", ValueTypes.c1, ValueTypes.c2);
            Console.WriteLine(ValueTypes.Sunny);

            //Reference Types
            Console.WriteLine(ReferenceTypes.String);
        }    
     }
 }

