using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsConsoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            try//we put all the code that can fail inside of a try and catch block,such that if the program fails we can tell what went wrong
            {


                Console.WriteLine("a program to divide two numbers");

                Console.WriteLine("enter the first number");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the second number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);//this will divide the two numbers,remember divition by zero is forbidden

            }
            //we can specify our error messages such that in case of a breakage the program continues
            catch(DivideByZeroException e )//this will get and display the exact error mesage with details of what went wrong
            {

                Console.WriteLine(e.Message);//this is our error message
            }
            catch (FormatException e)//this will get and display the exact error mesage with details of what went wrong
            {

                Console.WriteLine(e.Message);//this is our error message
            }
            Console.ReadLine();
           
        }
      
    }
}     