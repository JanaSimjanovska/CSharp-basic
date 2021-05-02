using System;
using AcademyAppClassLibrary.Entities.Enums;
using AcademyAppClassLibrary.Entities.Models;
using AcademyAppServices;
using System.Collections.Generic;
using AcademyAppClassLibrary;

namespace AcademyManagementApp
{
    class Program
    {
        
        static void Main(string[] args)
        {




            while (true)
            {
                try
                {
                    LoginMenu.MainMenuLogin(MembersDB.Members, MembersDB.Admins, MembersDB.Trainers, MembersDB.Students);
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("\nOops! Looks like something went wrong. Let's see what...");
                    Console.WriteLine($"\n{ex.Message}");
                    Console.WriteLine("\nPlease try again.");
                    LoginMenu.PressAnyKey();

                }
            }




        }
    }
}
