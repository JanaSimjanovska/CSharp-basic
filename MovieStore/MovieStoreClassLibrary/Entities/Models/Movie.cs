using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreClassLibrary.Entities.Enums;

namespace MovieStoreClassLibrary.Entities.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
        public bool IsRented { get; set; }
        private int Price { get; set; }

        public Movie(string title, string description, int year, Genre genre)
        {
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
            Price = SetPrice();
            IsRented = false;
        }

        private int SetPrice() 
        {
            Random random = new Random();

            if (Year < 2000)           
                Price = random.Next(100, 200);                          
             
            else if (Year >= 2000 && Year <= 2010)           
                Price = random.Next(200, 300);
                                       
            else           
                Price = random.Next(300, 400);    
            
            return Price;
        }

    }
}
