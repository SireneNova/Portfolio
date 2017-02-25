﻿using System;

namespace Delegate
{
    //Delegate: internal by default, type-safe function pointer
    //can be used to point to functions with a similar syntax, such as the 
    //way static void main does
   //This can point to any function with a void type and takes in a string parameter
   public delegate void HelloFunctionDelegate(string Message);

   class Program
    {
        public static void Main()
        {
            //Can create a new instance of the delegate as you would for a class.
            //Create for the function you point to 
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);

            //Use the funtion you point to this way:
            del("Hello from delegate");

        }
        
        public static void Hello(string strMsg)
        {
            Console.WriteLine(strMsg);
        }

        //Delegates are type safe because the delegate type signature 
        //must match the signature of the function it points to.
    }
}

//Source:
//https://www.youtube.com/watch?v=D2h46fvQX04
