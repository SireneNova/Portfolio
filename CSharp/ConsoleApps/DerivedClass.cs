using System;

namespace DerivedClass
{
    public class Parent
    {
        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }
    }

    public class Child : Parent
    {

        public int getProduct(int num1, int num2)
        {
            return num1 * num2;
        }

    }

    public class Entry
    {
        public static void Main()
        { 
            Child c = new Child();
                
            Console.WriteLine(c.getSum(3, 4));          
            Console.WriteLine(c.getProduct(3,4));
        }
    }
} 