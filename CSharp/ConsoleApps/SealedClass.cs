using System;

namespace Sealed
{
    public sealed class Parent //a class cannot be both static and sealed
    {
        //anything in this assembly (cs file) can access. derived classes in any assemblies can access too.
        public static int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        public static void Main() 
        {
            Console.WriteLine(getSum(3, 4)); //can't call from outside class, because sealed.
        }

        //public class Child : Parent // can't make a derived class, because sealed

    }
}