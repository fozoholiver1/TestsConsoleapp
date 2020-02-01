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
            string[,] names = { { "james ", "sinarch", } ,{ "john", "christabel" } };
           Console.WriteLine(names[1,0]);//in this multivariable array [1,0] 1 is the position while 0 is the value we want to print out e.g [1,0]/john ,[1,1]/chritabel
            Console.ReadLine();
        }   
    }
}
