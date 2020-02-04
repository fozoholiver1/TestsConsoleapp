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

            while (answer != index)//this condition will execute after the body is executed
            {

                Console.WriteLine("keep guessing");
                answer=Console.ReadLine();
            }
            Console.ReadLine();
        }
      
    }
}     