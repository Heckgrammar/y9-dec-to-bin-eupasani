using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 0; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int
           
            string greeting = "world!";
            greeting = greeting.Insert(0, "Hello ");
            Console.WriteLine(greeting);
            //MAIN:  NUMBER CONVERSION PROGRAM
            Console.WriteLine("Enter a positive number and numberbase consecutively, pressing enter in between.");
            int enteredNum = Convert.ToInt32(Console.ReadLine());
            while (enteredNum <= 0 ) 
                {
                Console.WriteLine("Enter a positive number");
                enteredNum = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine( numberConversion(enteredNum,2));
            //CODE GOES HERE
        }

        ////static void means the function will not return a value so it does not need a data type 
        ////...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            //    //CODE GOES HERE 
            int remainder = 0;
            string result = "";
            while (number != 0)
            {
                remainder = number % numberbase;
                number = number / 2;
                result = result.Insert(0, Convert.ToString(remainder));
            }
            return result; //REMOVE THE RED LINE! 
        }
    }
}


















 












































































