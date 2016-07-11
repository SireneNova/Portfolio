using System;

namespace AbstractClassVsInterface
{
    //Abstract class can have access modifiers. Private by default.
    public abstract class absParent
    {
        //Abstract class can have methods w implementation
        public static void Print()
        {
            Console.WriteLine("Implementation");
        }

        public abstract int Add(int num1, int num2);
    }


    // Interface is public by default. No access modifiers.
    interface IParent
    {
        /*Can't implement in interface. This doesn't work:
        public void Print()
        {
            Console.WriteLine("implementation");
        }*/

        //All you can do is introduce method:
        int IAdd(int num1, int num2);
    }

    public class Child : absParent, IParent
    {
        // Need override mod for class override.
        override public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // No override mod needed.
        public int IAdd(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Main()
        {
            Print(); //from abs class

            //Can instantiate interface:
            IParent p = new Child();
            Console.WriteLine(p.IAdd(2,5));

            //Can't instantiate abs class, eg:
            //absParent a = new absParent;

            Child c = new Child();
            Console.WriteLine(c.Add(6,3));

        }
    }
}