﻿using System;
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
            Console.WriteLine(" enter your name");//this program takes a name and age and print them together
            string name = Console.ReadLine();
            Console.WriteLine(" enter your age");
            string age = Console.ReadLine();

            Console.WriteLine("hello " + name + " you are " + age 
                
                + " years old");

            Console.ReadLine();
        }   
    }
}
