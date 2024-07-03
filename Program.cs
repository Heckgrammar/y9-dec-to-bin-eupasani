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
        static string Valid(string input)
        {
            Console.WriteLine("Enter a positive number and numberbase consecutively, pressing enter in between.");
            input = Console.ReadLine();
            int enteredNum = Convert.ToInt32(input);
            while (enteredNum <= 0 || Convert.ToString(enteredNum) != Convert.ToString(Convert.ToInt32(input)))
            {
                Console.WriteLine("Enter a positive number");
                enteredNum = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(numberConversion(enteredNum, 2));
            return input;
        }
    }
}





























































































