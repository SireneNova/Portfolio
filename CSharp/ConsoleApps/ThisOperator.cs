using System;

namespace ThisOperator
{
    class ExampleThis
    {
        string FirstName;
        string LastName;
        
        // Constructor:
        public ExampleThis(string FirstName, string LastName)
        {
            // Use this to qualify the fields:
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public void printName()
        {
            Console.WriteLine("First: {0}\n Last: {1}", FirstName, LastName);
        }
    }

    class MainClass
    {
        static void Main()
        {
            // Create objects:
            ExampleThis E1 = new ExampleThis ("Peter", "Pan");
            E1.printName();
        }
    }
}
//https://msdn.microsoft.com/en-us/library/dk1507sz.aspx
