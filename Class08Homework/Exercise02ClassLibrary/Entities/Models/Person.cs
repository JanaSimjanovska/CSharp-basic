using System;
using System.Collections.Generic;
using System.Text;
using Exercise02ClassLibrary.Entities.Enums;

namespace Exercise02ClassLibrary.Entities.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Genre FavoriteGenre { get; set; }

        public List<Song> FavoriteSongs { get; set; }

        public Person(int id, string firstName, string lastName, int age, List<Song> favoriteSongs, Genre favoriteGenre)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteSongs = favoriteSongs;
            FavoriteGenre = favoriteGenre;
        }

        public void GetFavSongs()
        {

            Console.WriteLine("Checking for this persons favorite songs...");
            Console.WriteLine(".............");

            if (FavoriteSongs.Count == 0)
                Console.WriteLine("Oh! It looks like this person hates music :O)");
           
            else
            {
                foreach (Song song in FavoriteSongs)
                    Console.WriteLine(song.Title);
            }
          
        }
    }
}
