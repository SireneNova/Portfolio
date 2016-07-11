using System;

namespace Interfaces
{
    interface IMom //implicitly public and virtual
    {
        double getQuotient(double num1 = 1, double num2 = 1); //cannot have definition in interface
    }

    interface IDad
    {
        int getSum(int num1 = 1, int num2 = 1);
    }

    interface IChild : IMom //interfaces can inherit other interfaces
    {
        int getProduct(int num1 = 1, int num2 = 1);

    }

    public class Child : IMom, IDad, IChild // same syntax as deriving from a class, but can do multiple interfaces. nothing to override, just define the inherited methods.
    {
        public double getQuotient(double num1 = 1, double num2 = 1)
        {
            return num1 / num2;
        }

        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        public int getProduct(int num1 = 1, int num2 = 1)
        {
            return num1 * num2;
        }

    }
    
    public class Entry
    {
        public static void Main()
        {
            //Can implement from classes same way:
            Child c = new Child();
            Console.WriteLine(c.getSum());
            Console.WriteLine(c.getQuotient(3, 4));
            Console.WriteLine(c.getProduct(3, 4));

            //Another format:
            IMom m = new Child();
            double mresult = m.getQuotient(4, 5);
            Console.WriteLine(mresult);
        }
    }
}
 