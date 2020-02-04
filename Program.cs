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
            Console.WriteLine("what is the capital of cameroon");
            string index = "younde";
            string answer = "";

            while (index != answer)//this condition will cause infinite loop
            {
                Console.WriteLine("keep guessing");
            }
            Console.ReadLine();
        }
      
    }
}     