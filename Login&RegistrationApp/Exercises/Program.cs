using Exercises.Models;
using System;

namespace Exercises
{

    class Program
    {
        // Probaj da dodades funkcionalnost da moze da izleze skroz od aplikacijata, i proveri dali se dodeka e aktivna i se dodavaat novi juzeri, dali se zacuvuva dobro nizata so objekti juzeri i porakite od sekoj nov.
        static User[] CheckStatusOfApp(User[] users)
        {

            User[] updatedUsersArray = users;

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Enter 1 to login to your account and 2 to register!");
            Console.WriteLine("---------------------------------------------------");


            bool isLogInOrRegisterSuccess = int.TryParse(Console.ReadLine(), out int userInput);

                while (!isLogInOrRegisterSuccess)
                {
                    Console.WriteLine("You didn't enter a number. Please choose 1 to login or 2 to register!");
                    isLogInOrRegisterSuccess = int.TryParse(Console.ReadLine(), out userInput);
                }

                if (userInput != 1 && userInput != 2)
                {
                    Console.WriteLine("You can choose either 1 or 2.");
                    CheckStatusOfApp(updatedUsersArray);
                }
                else if (userInput == 2)
                {
                    updatedUsersArray = Register(updatedUsersArray);
                    
                    Console.WriteLine("Thank you for registering.");
                    CheckStatusOfApp(updatedUsersArray);
                }
                else
                    Login(updatedUsersArray);

            return updatedUsersArray;

        }

        static User CheckIfUserExists(User[] users, string username, string password)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (Equals(users[i].Username, username) && Equals(users[i].Password, password)) return users[i];
            }
            return null;
        }

        static void Login(User[] users) 
        {
            Console.WriteLine("Enter a username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter a password");
            string password = Console.ReadLine();

            User user = (CheckIfUserExists(users, username, password));
            while(user == null)
            {
                Console.WriteLine("Sorry. no such user exists. Please try again!");
                CheckStatusOfApp(users);
            }

            Console.WriteLine("These are your messages:");
            user.ShowMessages();
            CheckStatusOfApp(users);
        }

        static User[] Register(User[] users) // NE TI GI ZACUVUVA NOVITE JUZERI VO NIZATA OTKAKO KJE ZAVRSI REGISTRACIJATA I TOA STO IM PRIKAZUVAS
        {
            Console.WriteLine("Enter a username");
            string username = Console.ReadLine();
            while (username.Length < 5 || username.Length > 19)
            {
                Console.WriteLine("Please enter a username that is longer than 4 characters and shorter than 20!");
                username = Console.ReadLine();

            }

            foreach (User user in users)
            {
                while (Equals(user.Username, username))
                {
                    Console.WriteLine("This username already exists! Please try again with a different username!");
                    Register(users);
                }
            }

            Console.WriteLine("Enter a password");
            string password = Console.ReadLine();
            while (password.Length < 8)
            {
                Console.WriteLine("Please enter a password that is longer than 8 characters!");
                password = Console.ReadLine();
            }

            Console.WriteLine("Would you like to save a new message (Y/N)?");
            string[] messages = { };
            string yesOrNo = Console.ReadLine();
            while (yesOrNo.ToLower() != "y" && yesOrNo.ToLower() != "n")
            {
                Console.WriteLine("Please enter Y if you want to enter new message, or N if you don't!");
                yesOrNo = Console.ReadLine();
            }
            while (yesOrNo.ToLower() != "n" && yesOrNo.ToLower() == "y")
            {
                Console.WriteLine("Enter your message:");
                string message = Console.ReadLine(); 
                Array.Resize(ref messages, messages.Length + 1);
                messages[messages.Length - 1] = message;
                Console.WriteLine("Would you like to save another message (Y/N)?");
                yesOrNo = Console.ReadLine();
                while (yesOrNo.ToLower() != "y" && yesOrNo.ToLower() != "n")
                {
                    Console.WriteLine("Please enter Y if you want to enter new message, or N if you don't!");
                    yesOrNo = Console.ReadLine();
                }
            }

            if(messages.Length > 0)
            Console.WriteLine(messages[messages.Length - 1]);

            Array.Resize(ref users, users.Length + 1);
            int id = users.Length;
            
            users[users.Length - 1] = new User(id, username, password, messages);

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Here's a list of usernames of users registered so far:");
            Console.WriteLine("------------------------------------------------------");

            foreach (User item in users)
            {
                Console.WriteLine($"{item.Id}. {item.Username}");

            }

            if(users[users.Length - 1].Messages.Length != 0)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("And here are your messages:");
                Console.WriteLine("---------------------------");
                users[users.Length - 1].ShowMessages();

            }

            return users;
        }
        
        static void Main(string[] args)
        {
            /*
            Create a program that will represent User Login and Register functionality
            - The User should have two options : 
                1) Log in 
                2) Register
            - Class User: Id, Username, Password, Messages
            - If a user is successfully logged in, it should show his messages
                e.g. Your messages: "his message here"
            - Note: Provide basic Login and Register validation
            */
        
            User[] users = new User[]
            {
                new User( 1, "Admin", "password", new string[]{ "Message 1", "Message 2" } ),
                new User( 2, "user2", "password2", new string[]{ "Bla", "Bla bla" })
            };

            CheckStatusOfApp(users);
           

            Console.ReadLine();
        }
    }
}
