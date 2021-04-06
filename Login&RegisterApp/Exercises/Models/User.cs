using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }

        public User()
        {
        }

        public User(int id, string username, string password, string[] messages)
        {
            Id = id;
            Username = username;
            Password = password;
            Messages = messages;
        }


        public void ShowMessages()
        {
            for (int i = 0; i < Messages.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Messages[i]}"); 
            }
        }
    }
}
