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
            Student student1 = new Student("john" ,"arts",3.6) ;//the constructor allows us to pass values as variables in our program 

            Student student2 = new Student("oliver", "chemistry", 2.6);//the constructor allows us to pass values as variables in our program  

            Console.WriteLine(student1.name);//this will print ou the title of our first book

            // gettiing results from our construct methods 
            Console.WriteLine(student1.Hashornors());//checking wether student on has hornors or not from our class sam in the precieding line
            Console.WriteLine(student2.Hashornors());
            Console.ReadLine(); 
        }
      
    }
}     