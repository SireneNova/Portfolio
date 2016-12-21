using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class SimpleLoop
    {
       static void Count(int n)
        {
            for (int i=0; i<n; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Count(6);
        }
    }
}
