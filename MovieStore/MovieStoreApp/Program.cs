using System;
using MovieStoreClassLibrary.Entities.Enums;
using MovieStoreClassLibrary.Entities.Models;
using System.Collections.Generic;
using MovieStoreServices;

namespace MovieStoreApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
           

            #region Members list

            List<Member> members = new List<Member>();
            List<int> userIds = new List<int>();


            members.Add(new Employee("Jana", "Simjanovska", "29", "Admin", "password", "077739567", new DateTime(2021, 1, 1), 180));
            members.Add(new Employee("Blaaa", "Blaaaa", "45", "ttttt", "pasvord", "070707070", new DateTime(1960, 3, 4), 120));
            members.Add(new User("Anastas", "Godzo", "28", "Bucifer", "aldo1234", "070999999", new DateTime(2021, 2, 17), Subscription.Annualy, userIds));

            #endregion


            #region Movie list

            List<Movie> moviesForRent = new List<Movie>
            {
                new Movie("My Father the Hero", "A teenage girl on vacation in the Bahamas with her divorced father tries to impress a potential boyfriend by saying that her father is actually her lover.", 1994, Genre.Comedy),
                new Movie("Insidious", "A family looks to prevent evil spirits from trapping their comatose child in a realm called The Further.", 2010, Genre.Horror),
                new Movie("Grease", "Good girl Sandy Olsson and greaser Danny Zuko fell in love over the summer. When they unexpectedly discover they're now in the same high school, will they be able to rekindle their romance?", 1978, Genre.Musical),
                new Movie("The Silence of the Lambs", "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.", 1991, Genre.Thriller),
                new Movie("Sherlock Holmes", "Detective Sherlock Holmes and his stalwart partner Watson engage in a battle of wits and brawn with a nemesis whose plot is a threat to all of England.", 2009, Genre.Mystery),
                new Movie("Interstellar", "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", 2014, Genre.Sci_fi),
                new Movie("Django Unchained", "With the help of a German bounty-hunter, a freed slave sets out to rescue his wife from a brutal plantation-owner in Mississippi.", 2012, Genre.Western),
                new Movie("The Notebook", "A poor yet passionate young man falls in love with a rich young woman, giving her a sense of freedom, but they are soon separated because of their social differences.", 2004, Genre.Romance),
                new Movie("The Transporter", "Frank Martin, who \"transports\" packages for unknown clients, is asked to move a package that soon begins moving, and complications arise.", 2002, Genre.Action),
                new Movie("Harry Potter and the Philosopher's Stone", "An orphaned boy enrolls in a school of wizardry, where he learns the truth about himself, his family and the terrible evil that haunts the magical world.", 2001, Genre.Fantasy),
                new Movie("The King's Speech", "The story of King George VI, his impromptu ascension to the throne of the British Empire in 1936, and the speech therapist who helped the unsure monarch overcome his stammer.", 2010, Genre.Drama),
                new Movie("Madagascar", "A group of animals who have spent all their life in a New York zoo end up in the jungles of Madagascar, and must adjust to living in the wild.", 2005, Genre.Animated),
                new Movie("Indiana Jones and the Temple of Doom", "In 1935, Indiana Jones arrives in India, still part of the British Empire, and is asked to find a mystical stone. He then stumbles upon a secret cult committing enslavement and human sacrifices in the catacombs of an ancient palace.", 1984, Genre.Adventure),
                new Movie("Schindler's List", "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.", 1993, Genre.Historical),
            };

            #endregion


           while (true)
           {
                try
                {
                    MovieStoreAppFunctionalities.CheckStatusOfApp(members, moviesForRent, userIds);
                }

                catch (Exception ex)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOops, looks like something went wrong :( You probably didn't enter a number :/ Let's see:");
                    Console.WriteLine($"\n{ex.Message}");
                    Console.WriteLine("\nOh well, NVM :) Just give it another shot.");
                    Console.ResetColor();
                    MovieStoreAppFunctionalities.PressAnyKey();
                }
           }
        }
    }
}
