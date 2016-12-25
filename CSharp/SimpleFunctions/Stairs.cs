using System;

namespace Test
{
    class Stairs
    {
        static void Staircase(int n)
        {
            for (string i = ""; i.Length <= n; i = i + "#")
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Staircase(6);
        }
    }
}
