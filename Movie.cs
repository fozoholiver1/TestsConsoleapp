using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsConsoleapp
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string atitle, string adirector, string arating) //our construct
        {
            title = atitle;
            director = adirector;
            Rating = arating;
        }
            //since rating is a private variable we have to create a get and setter for the ratings
        public string Rating
        {
            get{ //this will get any value passed to the ratting variable 
                return rating;
            }
            set//this will compare the ratings with these set value to either proceed or to return a default value
            {
                if (rating == "PG"||value=="PG-13"||value=="R"||value=="NR"||value=="G")
                {

                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
            
        }
    }
}
