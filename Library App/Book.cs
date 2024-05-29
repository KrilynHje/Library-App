using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App
{
    internal class Book
    {  
        public string Title { get; set; }   
        public string Description { get; set; }
        public string Author { get; set; }  
        public int NumberOfPages {  get; set; } 
        
        public Book(string title, string description, string author, int numberOfPages) 
        {
            Title = title; 
            Description = description;  
            NumberOfPages = numberOfPages;
            Author = author;            
        }   
    }
}
