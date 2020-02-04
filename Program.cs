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
            int index = 6;
            do
            {
                Console.WriteLine(index);//this line of code will excutute before checking the conditions
                index++;
            }
            while ( index<=5); //condition
            Console.ReadLine();
        }
      
    }
}     