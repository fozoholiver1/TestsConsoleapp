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

            Console.WriteLine("a program to divide two numbers");

            Console.WriteLine("enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 / num2);//this will divide the two numbers,remember divition by zero is forbidden

        }
      
    }
}     