using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsConsoleapp
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student( string aname , string amajor ,double agpa)
        {

            name = aname;
            major = amajor;
            gpa = agpa;
        }
        public bool  Hashornors()
        {
            if(gpa>3.5)
            {
                
                    return true;

                }
                    return false;
                
            
        }

    }
}
