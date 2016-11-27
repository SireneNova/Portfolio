using System;

namespace AbstractClassVsInterface
{
    //Abstract class can have access modifiers. Private by default.
    public abstract class absParent
    {
        //Abstract class can have methods w implementation (static or instance)
        public static void Print()
        {
            Console.WriteLine("Implementation");
        }
        
        //Any class with an abstract method is an abstract class:
        public abstract int Add(int num1, int num2);
    }


    // Interface is public by default. No access modifiers.
    // Only contain abstract methods
    interface IParent
    {
        /*Can't have methods with implementation. (No instance or static methods.) This doesn't work:
        public void Print()
        {
            Console.WriteLine("implementation");
        }*/

        //All you can do is introduce abstract method :
        int IAdd(int num1, int num2);
    }

    public class Child : absParent, IParent
    {
        // Need override mod for class override in c#.
        override public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // No override mod needed.
        public int IAdd(int num1, int num2)
        {
            return num1 + num2;
        }
//Not shown - classes can inherit from a single abstract base class (single inheritance) but multiple interfaces.
        public static void Main()
        {
            Print(); //from abs class

            //Can't instantiate abs class or interface directly. This doesn't work: 
            //absParent a = new absParent;
            
            //indirectly:
            IParent p = new Child();
            Console.WriteLine(p.IAdd(2,5));
           
            Child c = new Child();
            Console.WriteLine(c.Add(6,3));

        }
    }
}
