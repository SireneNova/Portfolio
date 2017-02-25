using System;

namespace WindowsSeriesDrill
{
    //public- any other code can access
    public class Parent
    {
        //protected - can be accessed by same class or derived class inside or outside assembly
        protected double getQuotient(double num1 = 1, double num2 = 1)
        {
            return num1 / num2;
        }

        //protected internal - anything in this assembly can access. derived classes in any assemblies can access too.
        protected internal int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }
                
    }

    public class Child : Parent
    {
        //getQuotient (protected) can be accessed here because Child is a derived class 
        public double addtoQuotient(double num1 = 1, double num2 = 1)
        {
            return 5 + getQuotient(num1, num2);
        }

        //internal - can be accessed by this assembly, but not other assemblies 
        internal int getProduct(int num1, int num2)
        {
            return num1 * num2;
        }

        //private - can only be accessed within this class
        private int getDiff(int num1, int num2)
        {
            return num1 - num2;
        }

    }

    public class Entry
    {
        public static void Main(string[] args)
        { 
            Child c = new Child();
                
            Console.WriteLine(c.getSum()); //assembly accesses internal protected getSum. also uses default values here.        
            Console.WriteLine(c.getProduct(3, 4)); //assembly accesses internal getProduct.
            Console.WriteLine(c.addtoQuotient(3, 4)); //accesses public addtoQuotient function, which in turn accesses protected quotient function.
            //Console.WriteLine(c.getQuotient(3, 4)); //can't be accessed due to protected setting. can be accessed by it's own class or derived classes. see addtoQuotient.
            //Console.WriteLine(c.getDiff(3, 4)); //can't be accessed due to private setting. can only be accessed within child class.
        }
    }
} 
