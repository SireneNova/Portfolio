using System;

namespace OverloadingOverriding
{
    // Overload
    // Gives added function to a method (getSum here)
    public class Overload
    {
        public static int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        public static double getSum(double num1, double num2)
        {
            return num1 + num2;
        }

    }

    // Override
    public abstract class Parent
    {
        // Declare a Method
       public abstract int getProduct(int num1, int num2);
    }

    public class Child:Parent
    {
        // Override methods with the keyword new
        // Adds or overrides functionality in derived class (polymorphism)
       
        public override int getProduct(int num1, int num2)
        {
            return num1 * num2;
        }
    }
                
    public class Entry
    {
        public static void Main(string[] args)
        { 
            // Overloading result
            Console.WriteLine(Overload.getSum(3, 4));
            Console.WriteLine(Overload.getSum(num2: 3.4, num1: 4.5));

            // Overriding result
            // First need new instance of Child class since not static
            Child c = new Child();
            Console.WriteLine(c.getProduct(3, 4));
        }
    }
} 
