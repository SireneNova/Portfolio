using System;

namespace Test
{
    class SimpleLoop
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
