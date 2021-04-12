using System;
using System.Collections.Generic;
using Exercise02ClassLibrary.Entities.Enums;
using Exercise02ClassLibrary.Entities.Models;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercises 1 & 2 from Class 08");
            Console.WriteLine("-------------------------------------------------------");


            #region Exercise 01

            Console.WriteLine("Exercise 01");

            Dictionary<string, int> phonebook = new Dictionary<string, int>
            {
                { "Jana", 077739567 },
                { "Anastas", 070111111 },
                { "John", 070223305 }
            };

            phonebook.Add("Jack", 075111111);
            phonebook.Add("Jill", 076222222);

            //foreach (var item in phonebook)
            //{
            //    Console.WriteLine(item);   
            //}


            //Console.WriteLine(phonebook.ContainsKey("Jana"));
            //Console.WriteLine(phonebook.ContainsKey("Jna"));


            Console.WriteLine("Enter a name to search the phonebook:");
            string userInputName = Console.ReadLine();

            if (!phonebook.ContainsKey(userInputName))
            {
                Console.WriteLine("Sorry :( No such person in the phonebook.");
            }
            else
            {
                foreach (var item in phonebook)
                {
                    if (userInputName != item.Key)
                        continue;
                    else
                    {
                        string formattedNumber = string.Format("{0:0##-###-###}", item.Value);
                        Console.WriteLine($"The person that you were looking for is in the phonebook, and their phone number is {formattedNumber}.");
                    }

                }
            }

            Console.WriteLine("-------------------------------------------------------");


            #endregion


            #region Exercise 02

            Console.WriteLine("Exercise 02");

            Song firstSong = new Song("Title of song no.1", "3:48", Genre.Rock);
            Song secondSong = new Song("Title of song no.2", "5:08", Genre.Techno);
            Song thirdSong = new Song("Title of song no.3", "2:55", Genre.Rock);

            List<Song> happysFavSongs = new List<Song>() { firstSong };
            happysFavSongs.AddRange(new List<Song>() { secondSong, thirdSong });
            List<Song> grumpysFavSongs = new List<Song>();
            Console.WriteLine(grumpysFavSongs.Count);

            Person happyPerson = new Person(1, "Happy", "Caldwell", 55, happysFavSongs, Genre.Rock);
            Person grumpyPerson = new Person(2, "Oscar", "the Grouch", 43, grumpysFavSongs, Genre.Hates_Music);

            happyPerson.GetFavSongs();
            grumpyPerson.GetFavSongs();

            #endregion


            Console.ReadLine();
        }

    }
}
