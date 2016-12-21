using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCoTest
{
    class SimpleLoop
    {
       static void StairCase(int n)
        {
            for (int i=0; i<n; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            StairCase(6);
        }
    }
}
