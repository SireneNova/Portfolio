using System;
using System.Collections.Generic;

namespace Delegate
{
    //Before Delegate, not reusable code:
    /*class Program
    {
        public static void Main()
        {
            List<Employee> empList = new List<Employee>;

            empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 102, Name = "Mike", Salary = 6000, Experience = 6 });

            Employee.PromoteEmployee(empList);
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        //The following is not reusable, b/c hardcoded for experience. Could want to run for Salary etc.
        public static void PromoteEmployee(List<Employee> employeeList)
        {
            foreach (Employee emp in employeeList)
            {
                if (emp.Experience >= 5) //this tests for a true or false, so delegate will be boolean, see below
                {
                    Console.WriteLine(emp.Name + " promoted");
                }
            }
        }
    }*/

    //Delegate: instead want to pass in method as paremeter in the if:
/*
    class Program
    {
        public static void Main()
        {
            List<Employee> empList = new List<Employee>;

            empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 102, Name = "Mike", Salary = 6000, Experience = 6 });

            //Need PromoteEmployee to take a fuction instead, so:
            IsPromotable isPromotable = new IsPromotable(Promote);
            Employee.PromoteEmployee(empList, isPromotable);
        }

        public static bool Promote(Employee emp)
        {
            if(emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    delegate bool IsPromotable(Employee empl);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        //The following is not reusable, b/c hardcoded for experience. Could want to run for Salary etc.
        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsElligibleToPromote) //This function is taking another function as param
        {
            foreach (Employee employee in employeeList)
            {
                if (IsElligibleToPromote(employee)) 
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }
    }*/

    //Can instead use lambda expression:
    class Program
    {
        public static void Main()
        {
            List<Employee> empList = new List<Employee>;

            empList.Add(new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 102, Name = "Mike", Salary = 6000, Experience = 6 });

            //Need PromoteEmployee to take a fuction instead, so:

            /*You don't need this:
            IsPromotable isPromotable = new IsPromotable(Promote);*/

            Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);
        }
        /*And you don't need this:
        public static bool Promote(Employee emp)
        {
            if(emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }

    delegate bool IsPromotable(Employee empl);

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        //The following is not reusable, b/c hardcoded for experience. Could want to run for Salary etc.
        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsElligibleToPromote) //This function is taking another function as param
        {
            foreach (Employee employee in employeeList)
            {
                if (IsElligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }
    }
}