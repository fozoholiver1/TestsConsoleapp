using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsConsoleapp
{
    class Book
    {
        public string author;
        public string title;
        public int pages;
        //this is the beginning of ou constructor
        public Book(string iauthor , string ititle, int ipages)//this is our constructor ,these variables are different from the ones in our class
        {
            author = iauthor;//assigning variable to class variables 
            title = ititle;
            pages = ipages;

        }
    }
    
}
