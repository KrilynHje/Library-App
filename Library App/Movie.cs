using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App
{
    internal class Movie
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public string Director {get; set;}
       
        public int MovieLength { get; set; } 

        public Movie(string title, string description,string directior, int movieLength) 
        { 
               
            Title = title;  
            Description = description;
            Director = directior; 
            MovieLength = movieLength;  
           
        }
    }
}
