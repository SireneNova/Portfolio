using System;

namespace Test
{
    class Stairs
    {
        internal static void Staircase(int n)
        {
            for (string i = ""; i.Length <= n; i = i + "#")
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
