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

            //Can't instantiate abs class or interface directly. They are only meant to be extended. This doesn't work: 
            //absParent a = new absParent;
            
            //indirectly:
            IParent p = new Child();
            Console.WriteLine(p.IAdd(2,5));
           
            // 
            Child c = new Child();
            Console.WriteLine(c.Add(6,3));

        }
    }
}

/*
Uses:
* Both support polymorphism in inheriting objects. Structs can only inherit from interfaces.
* Abstract classes can share states and functionalities with derived objects, while interfaces cannot. A good use for an abstract class is to create objects that are subcategories of itself, giving them default/base properties. This helps avoid repeating the shared code.
* Both abstract classes and interfaces can declare that a state or functionality should exist in derived objects. This is all interfaces do.
* Classes and structs can inherit from multiple interfaces. 
* Interfaces are best used when inheritance of multiple interfaces with no base implementation is desired and to give struct polymorphism.

Sources:
C# Succinctly by Joe Mayo (book)
https://www.youtube.com/watch?v=AU07jJc_qMQ&index=2&list=LLgg5TrwB0taT5IXe67j0H1Q
https://www.youtube.com/watch?v=hlLqvwocSr4
http://stackoverflow.com/questions/479142/when-to-use-an-interface-instead-of-an-abstract-class-and-vice-versa
*/
