﻿using System;

namespace OverloadingOverriding
{
    // Overload
    // Gives added function to a method (getSum here) in a class by defining it multiple times in different ways. 
    // It has the same method name, but different arguments.
    //In the following example, when the method getSum is run works for both integers or doubles because there is a method defined for them both.
    
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
            // Results of overloaded method
            Console.WriteLine(Overload.getSum(3, 4));
            Console.WriteLine(Overload.getSum(num2: 3.4, num1: 4.5));

            // Result of overriden method
            // First need new instance of Child class since not static
            Child c = new Child();
            Console.WriteLine(c.getProduct(3, 4));
        }
    }
} 
