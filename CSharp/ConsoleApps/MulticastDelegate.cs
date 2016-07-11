using System;
using System.Collections.Generic;

namespace MulticastDelegate
{
    //Multiclass delegate references more than one function. Invokes them all when invoked.
    public delegate void SampleDelegate();

    class Program
    {
        public static void Main()
        {
            SampleDelegate del1, del2, del3, del4;
            del1 = new SampleDelegate(sampleMethod1);
            del2 = new SampleDelegate(sampleMethod2);
            del3 = new SampleDelegate(sampleMethod3);

            del4 = del1 + del2 + del3-del2;
            del4(); //This is the multicast delegate

            //Another way
            SampleDelegate del = new SampleDelegate(sampleMethod1);
            del += sampleMethod2;
            del += sampleMethod3;
            del -= sampleMethod1;

            del();

        }

        public static void sampleMethod1()
        {
            Console.WriteLine("sampleMethod1 invoked");
        }

        public static void sampleMethod2()
        {
            Console.WriteLine("sampleMethod2 invoked");
        }

        public static void sampleMethod3()
        {
            Console.WriteLine("sampleMethod3 invoked");
        }

        public static void sampleMethod4()
        {
            Console.WriteLine("sampleMethod4 invoked");
        }
    }


    //For comparison:
    /*Regular Delegate:
    public delegate void SampleDelegate();

    class Program
    {
        public static void Main()
        {
            SampleDelegate del = new SampleDelegate(SampleMethod1);
            del();
        }

        public static void SampleMethod1()
        {
            Console.WriteLine("samplemethodone");
        }
    }*/

    //https://www.youtube.com/watch?v=7uJYp9NIhfQ

}