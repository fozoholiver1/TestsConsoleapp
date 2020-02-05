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
            Book book1 = new Book(" the mine of life" ,"oliver",7978798) ;//the constructor allows us to pass values as variables in our program  
            Book book2 = new Book(" the help of life", "mike doe", 09987);//this the second instance of oure book class    
            //prop[iiopfoifoifoifyfuyfiyfiuu]
            Console.WriteLine(book1.title);//this will print ou the title of our first book

            Console.ReadLine(); 
        }
      
    }
}     