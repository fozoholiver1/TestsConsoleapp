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

            Console.WriteLine(Getday(56)); /*this code takes numbers and refer them to the days of the week*/
            Console.ReadLine();
        }   

        static string Getday(int daynumber)
        {
            string dayname;
            switch (daynumber)//the switch statement 
            {
                case 0:
                    dayname = "sunday";
                    break;
                case 1:
                    dayname = "monday";
                    break;
                case 2:
                    dayname = "tuesday";
                    break;
                case 3:
                    dayname = "wednesday";
                    break;
                case 4:
                    dayname = "thursday";
                    break;
                case 5:
                    dayname = "friday";
                    break;
                case 6:
                    dayname = "satuday";
                    break;
                case 7:
                    dayname = "friday";
                    break;

               default://the default option 
                    dayname = "invalid day";
                    break;
            }
            return dayname;
        }
    }
}
