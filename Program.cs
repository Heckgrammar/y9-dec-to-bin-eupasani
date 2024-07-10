using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int enteredNum = 0;
            bool valid = false;
            bool integer = false;
            Console.WriteLine("Choose from these: 1 for dec to bin; 2 for bin to dec");
            int conversion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a positive number not beginning with zero");
            string input = Console.ReadLine();
            
            while (valid == false) {
                while (integer == false)
                {
                    for (int i = 0; i <= 9; i++)
                    {
                        if (Convert.ToString(i) == input.Substring(0, 1))
                        {

                            integer = true;
                            break;
                        }
                        
                        
                            
                        

                        }
                    if (integer == false)
                    {
                        Console.WriteLine("Enter a positive number not beginning with zero");
                        input = Console.ReadLine();
                    }
                }
                if (integer == true)
                {
                    enteredNum = Convert.ToInt32(input);
                }
                if (enteredNum <= 0 && integer == true)
                {
                    Console.WriteLine("Enter a positive number not beginning with zero");
                    input = Console.ReadLine();
                    enteredNum = Convert.ToInt32(input);
                }
                else { valid = true; }


                if (conversion == 1)
                { 
                    Console.WriteLine("Enter the base");
                    int numBase = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(decToBin(enteredNum, numBase)    );
                }
                else if (conversion == 2)
                {
                    Console.WriteLine(bintodec(enteredNum));
                }
            }



        }
            static string decToBin(int number, int numberbase)
        {
            //    //CODE GOES HERE 
            int remainder = 0;
            string result = "";
            while (number != 0)
            {
                remainder = number % numberbase;
                number = number / numberbase;
                result = result.Insert(0, Convert.ToString(remainder));
            }
            return result; //REMOVE THE RED LINE! 
        }

        static string bintodec(int number)
        {
            int totalNum = 0;
            for (int i = 0; i < Convert.ToInt32(Convert.ToString(number).Length); i++)
            {
                string currentDigit = Convert.ToString(number).Substring(i, 1);
                int toDec = Convert.ToInt32( Math.Pow(Convert.ToDouble(2), i))  * Convert.ToInt32(currentDigit) ;
               
                 totalNum = totalNum + toDec;
            }

            string result = Convert.ToString(totalNum);
            return  result;
        }

    }
}





























































































