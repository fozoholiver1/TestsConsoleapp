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
            Movie movie1 = new Movie("war room" ,"oliver","PjjG") ;//the constructor allows us to pass values as variables in our program 

            Movie movie2 = new Movie("oliver", "chemistry", "PG-13");//the constructor allows us to pass values as variables in our program  

            Console.WriteLine(movie1.Rating);
            Console.ReadLine(); 
        }
      
    }
}     